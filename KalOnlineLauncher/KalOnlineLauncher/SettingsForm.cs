using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KalOnlineLauncher
{
    public partial class SettingsForm : Form
    {
        IniFile ini;
        public SettingsForm()
        {
            InitializeComponent();
            ini = new IniFile(Application.StartupPath + "\\Launcher.ini");
            bool muteSounds = false;
            try
            {
                muteSounds = Convert.ToBoolean(ini.ReadValue("Settings", "MuteSound"));
            }
            catch (Exception)
            {
            }
            muteCheckBox.Checked = muteSounds;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ini.WriteValue("Settings", "MuteSound", muteCheckBox.Checked.ToString());
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "http://www.arturasserver.com";
            p.StartInfo.Arguments = "";
            p.Start();
        }
    }
}
