using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KalOnlineLauncher
{
    public partial class KalButton : Button
    {
        public KalButton()
        {
            InitializeComponent();
            this.Size = new Size(111, 30);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundImage = KalOnlineLauncher.Properties.Resources.button;
            this.ForeColor = Color.White;
            this.MouseLeave += new EventHandler(KalButton_MouseLeave);
            this.MouseMove += new MouseEventHandler(KalButton_MouseMove);
            this.EnabledChanged += new EventHandler(KalButton_EnabledChanged);
            this.FlatAppearance.BorderSize = 0;
        }

        void KalButton_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.BackgroundImage = KalOnlineLauncher.Properties.Resources.button;
            }
            else
            {
                this.BackgroundImage = KalOnlineLauncher.Properties.Resources.button_disabled;
            }
        }

        void KalButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = KalOnlineLauncher.Properties.Resources.button_over;
        }

        void KalButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = KalOnlineLauncher.Properties.Resources.button;
        }
    }
}
