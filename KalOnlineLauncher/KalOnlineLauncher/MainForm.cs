using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockwaveFlashObjects;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Core;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace KalOnlineLauncher
{

    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        IniFile ini;
        Updater updater;

        string updateServer;
        decimal version;
        decimal launcherVersion = 1.0m;
        string updateFile;
        bool muteSound;

        string launcherSettings;
        public decimal ConvertToDecimal(string str)
        {
            decimal d = decimal.Parse(str, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-GB"));
            return d;
        }
        public MainForm()
        {
            InitializeComponent();

            //set settings file
            launcherSettings = Application.StartupPath + "\\Launcher.ini";
            //check if it exists
            if (!File.Exists(launcherSettings))
            {
                MessageBox.Show("Unable to locate Launcher.ini, program will now exit.");
                Environment.Exit(0);
            }

            //try and load settings
            try
            {
                //load settings
                ini = new IniFile(launcherSettings);
                //mute sound
                muteSound = Convert.ToBoolean(ini.ReadValue("Settings", "MuteSound"));
                //update server
                updateServer = "http://arturasserver.com/kalonline/panimalslauncher/server.php";
                //version
                try
                {
                    version = ConvertToDecimal(ini.ReadValue("Settings", "Version").Replace(',','.'));
                }
                catch (Exception)
                {
                    MessageBox.Show("It seems what ever retarded language you use doesnt like to provide decimals in a decent format.");
                    Environment.Exit(0);
                }
                //update file
                updateFile = Application.StartupPath+"\\" +ini.ReadValue("Settings", "UpdateFile");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to read settings file, program will now exit: " + ex.Message);
                Environment.Exit(0);
            }
           

            //open flash bg
            //shockwaveFlash.Movie = @"C:\Users\Arturas\Pictures\kal launcher\Background2.swf";
            string flashBG = Application.StartupPath + "\\UpdaterResources\\Background.swf";
            //check if file exists
            if (!File.Exists(flashBG))
            {
                MessageBox.Show("Error finding Resource, program will now exit.");
                Environment.Exit(0);
            }
            //load movie
            shockwaveFlash.Movie = flashBG;


            //mute sound
            if (muteSound)
            {
                MuteSound();
            }

            //start thread to load news,verions etc.
            Thread t = new Thread(new ThreadStart(LoadInfo));
            t.Start();

        }
        public void LoadInfo()
        {

            updater = new Updater(version, launcherVersion, updateServer);
            //set version text
            SetVersionText("Updater: v"+ launcherVersion + "/"+updater.GetServerLauncherVersion() + " - Game: v" + version.ToString() + "/"+updater.GetServerVersion());
            //check server status
            int serverStatus = updater.GetStatus();
            if (serverStatus == 0)
            {
                SetStatusText("<font color=\"#FF0000\">Offline</font>");

            }
            else if (serverStatus == 1)
            {
                SetStatusText("<font color=\"#99CC00\">Online</font>");
            }
            else
            {
                SetStatusText("<font color=\"#FFCC000\">Maintenance</font>");
            }

            //check if launcher needs update
            if (updater.LauncherRequiresUpdate())
            {
                MessageBox.Show("The launcher requires an update, your version: " + launcherVersion + " - Server: "+updater.GetServerLauncherVersion());
                Callback cb = new Callback(DownloadLauncherUpdate);
                this.Invoke(cb);
                
                return;
            }

            //check for updates
            if (updater.RequiresUpdate())
            {
                MessageBox.Show("The client requires an update, your version: " + version + " - Server: " + updater.GetServerVersion());
                try
                {
                    //get next version
                    nextVersion = updater.GetNextVersion(version);
                    //show update notes
                    SetNoticeText("Update Notes: v" + nextVersion.ToString(), updater.GetUpdateNotes(nextVersion));
                    Callback cb2 = new Callback(DownloadUpdate);
                    this.Invoke(cb2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update: " + ex.ToString());
                }
            }
            else
            {
                //show notice
                //MessageBox.Show("Ready");
                SetNoticeText("<b>Notice</b>", updater.GetNotice());
                Callback cb3 = new Callback(EnableStartButton);
                this.Invoke(cb3);
            }

            
        }

        WebClient wclient = new WebClient();
        decimal nextVersion;

        delegate void Callback();

        private void EnableStartButton()
        {
            startButton.Enabled = true;
        }

        private void DownloadLauncherUpdate()
        {
            wclient.DownloadFileCompleted += new AsyncCompletedEventHandler(wclient_DownloadLauncherFileCompleted);
            wclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wclient_DownloadProgressChanged);
            //begin download  
            wclient.DownloadFileAsync(new Uri(updater.GetLauncherUpdateURL()), updateFile);
        }
        private void DownloadUpdate()
        {
            wclient.DownloadFileCompleted += new AsyncCompletedEventHandler(wclient_DownloadFileCompleted);
            wclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wclient_DownloadProgressChanged);
            //begin download  
            try
            {
                wclient.DownloadFileAsync(new Uri(updater.GetUpdateURL(nextVersion)), updateFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading update: " + ex.ToString());
            }
        }

        void wclient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            SetUpdateProgress(e.ProgressPercentage);
        }

        void wclient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            InstallUpdate();
        }

        void wclient_DownloadLauncherFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            InstallLauncherUpdate();
        }

        private void InstallLauncherUpdate()
        {
            Zip.UnZipFile(updateFile);
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "launcher_update.exe";
                p.Start();
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to update launcher, program will now exit");
                Environment.Exit(0);
            }

        }

        private void InstallUpdate()
        {
            try
            {
                Zip.UnZipFile(updateFile);
                //write new game version to settings file
                ini.WriteValue("Settings", "Version", (nextVersion.ToString()).Replace(',','.'));
            }
            catch (Exception)
            {
                MessageBox.Show("Error Updating"); 
            }
            Application.Restart();
        }

        private void SetNoticeText(string Caption,string Text)
        {
            try
            {
                shockwaveFlash.CallFunction("<invoke name=\"setNoticeText\" returntype=\"xml\"><arguments><string>" + Caption + "</string><string>" + Text + "</string></arguments></invoke>");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Set Notice Text");
            }
        }

        private void SetStatusText(string Text)
        {
            try
            {
            shockwaveFlash.CallFunction("<invoke name=\"setStatusText\" returntype=\"xml\"><arguments><string>" + Text + "</string></arguments></invoke>");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Set Status Text");
            }
        }

        private void SetVersionText(string Text)
        {
            try
            {
                shockwaveFlash.CallFunction("<invoke name=\"setVersionText\" returntype=\"xml\"><arguments><string>" + Text + "</string></arguments></invoke>");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Set Version Text");
            }
        }

        private void MuteSound()
        {
            try
            {
            shockwaveFlash.CallFunction("<invoke name=\"muteSound\" returntype=\"xml\"><arguments></arguments></invoke>");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Mute Sound");
            }
        }

        private void SetUpdateProgress(int Progress)
        {
            //shockwaveFlash.SetVariable("notice_text", Text);
            shockwaveFlash.CallFunction("<invoke name=\"setUpdateProgress\" returntype=\"xml\"><arguments><number>" + Progress + "</number></arguments></invoke>");
        }

        private void backgroundPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeTopButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeBottomButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //todo
        private bool CheckFiles()
        {
            List<string> files = new List<string>();
            files.Add("engine.exe");
            files.Add("dbghelp.dll");
            foreach(string file in files)
            {
                if(File.Exists(file))
                {
                    string serverMD5 = updater.GetFileMD5(file);
                    string clientMD5 = GetMD5HashFromFile(file);
                    if (serverMD5 != clientMD5)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        protected string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void StartEngine()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "engine.exe";
                //p.StartInfo.Arguments = "/load /config debug";
                p.StartInfo.Arguments = updater.GetLauncherArgs();
                p.Start();
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start engine.exe");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (EngineIsClear() && DBGHelpIsClear())
            {
                StartEngine();
            }
            else
            {
                MessageBox.Show("Invalid files detected.");
            }
        }

        public bool EngineIsClear()
        {
            try
            {
                string remoteMD5 = updater.GetFileMD5("engine.exe");
                string localMD5 = GetMD5HashFromFile("engine.exe");
                if (remoteMD5.ToLower() == localMD5.ToLower())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DBGHelpIsClear()
        {
            try
            {
                string remoteMD5 = updater.GetFileMD5("dbghelp.dll");
                string localMD5 = GetMD5HashFromFile("dbghelp.dll");
                if (remoteMD5.ToLower() == localMD5.ToLower())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "http://www.panimals-server.com";
            p.StartInfo.Arguments = "";
            p.Start();
        }

        private void forumButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "http://www.panimalsserver.com/forum";
            p.StartInfo.Arguments = "";
            p.Start();
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "http://www.panimals-server.com/board/support";
            p.StartInfo.Arguments = "";
            p.Start();
        }
    }
}
