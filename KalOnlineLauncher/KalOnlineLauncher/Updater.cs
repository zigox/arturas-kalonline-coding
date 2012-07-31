using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
namespace KalOnlineLauncher
{
    public class Updater
    {
        decimal clientVersion;
        decimal serverVersion;

        decimal clientLauncherVersion;
        decimal serverLauncherVersion;

        string ServerURL;

        public Updater(decimal ClientVersion,decimal ClientLauncherVersion, string ServerURL)
        {
            this.clientVersion = ClientVersion;
            this.clientLauncherVersion = ClientLauncherVersion;
            this.ServerURL = ServerURL;
        }

        public bool RequiresUpdate()
        {
            serverVersion = GetServerVersion();
            if (clientVersion < serverVersion && serverVersion != -1.00m)
            {
                return true;
            }
            return false;
        }

        public bool LauncherRequiresUpdate()
        {
            serverLauncherVersion = GetServerLauncherVersion();
            if (clientLauncherVersion < serverLauncherVersion && serverLauncherVersion != -1.00m)
            {
                return true;
               
            }
            return false;
        }

        public decimal GetServerVersion()
        {
            try
            {
                WebClient wclient = new WebClient();
                return ConvertToDecimal(wclient.DownloadString(ServerURL + "?command=GetVersion"));
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve server version, please check your internet connection and try again.");
                return -1.00m;
            }
        }

        public decimal ConvertToDecimal(string str)
        {
            decimal d = decimal.Parse(str, NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-GB"));
            return d;
        }

        public decimal GetServerLauncherVersion()
        {
            try
            {
                WebClient wclient = new WebClient();
                return ConvertToDecimal(wclient.DownloadString(ServerURL + "?command=GetLauncherVersion"));
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve server launcher version, please check your internet connection and try again.");
                return -1.00m;
            }
        }

        public int GetStatus()
        {
            try
            {
                WebClient wclient = new WebClient();
                return Convert.ToInt32(wclient.DownloadString(ServerURL + "?command=GetStatus"));
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve server status, please check your internet connection and try again.");
                return 0;
            }
        }


        public decimal GetNextVersion(decimal version)
        {
            try
            {
                WebClient wclient = new WebClient();
                return ConvertToDecimal(wclient.DownloadString(ServerURL + "?command=GetNextVersion&arg1=" + version));
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve update version information, please check your internet connection and try again.");
                return -1.00m;
            }
        }

        public string GetUpdateNotes(decimal version)
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetUpdateNotes&arg1=" + version);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve update notes, please check your internet connection and try again.");
                return "Error connecting to update server.";
            }
        }
      
        public string GetUpdateURL(decimal version)
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetUpdateURL&arg1=" + version);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve update package location, please check your internet connection and try again.");
                return "";
            }
        }

        public string GetLauncherUpdateURL()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetLauncherUpdateURL");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve launcher update package location, please check your internet connection and try again.");
                return "";
            }
        }


        public string GetLauncherArgs()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetLauncherArgs");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve launch information, please check your internet connection and try again.");
                return "";
            }
        }

        public string GetFileMD5(string file)
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetFileMD5&arg1=" + file);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve MD5 information, please check your internet connection and try again.");
                return "";
            }
        }

        public string GetNotice()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(ServerURL + "?command=GetNotice");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to retrieve notice, please check your internet connection and try again.");
                return "Error connecting to update server.";
            }
        }



        public decimal ClientVersion
        {
            get
            {
                return this.clientVersion;
            }

        }

        public decimal ServerVersion
        {
            get
            {
                return this.serverVersion;
            }
        }

        public decimal ClientLauncherVersion
        {
            get
            {
                return this.clientLauncherVersion;
            }

        }

        public decimal ServerLauncherVersion
        {
            get
            {
                return this.serverLauncherVersion;
            }
        }
    }
}
