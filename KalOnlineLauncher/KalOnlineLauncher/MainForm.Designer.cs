namespace KalOnlineLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loadingLabel = new System.Windows.Forms.Label();
            this.shockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.closeTopButton = new System.Windows.Forms.PictureBox();
            this.closeBottomButton = new System.Windows.Forms.PictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new KalOnlineLauncher.KalButton();
            this.startButton = new KalOnlineLauncher.KalButton();
            this.supportButton = new KalOnlineLauncher.KalButton();
            this.forumButton = new KalOnlineLauncher.KalButton();
            this.websiteButton = new KalOnlineLauncher.KalButton();
            ((System.ComponentModel.ISupportInitialize)(this.shockwaveFlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeTopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBottomButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.Black;
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(397, 320);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(54, 13);
            this.loadingLabel.TabIndex = 2;
            this.loadingLabel.Text = "Loading...";
            // 
            // shockwaveFlash
            // 
            this.shockwaveFlash.Enabled = true;
            this.shockwaveFlash.Location = new System.Drawing.Point(22, 40);
            this.shockwaveFlash.Name = "shockwaveFlash";
            this.shockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("shockwaveFlash.OcxState")));
            this.shockwaveFlash.Size = new System.Drawing.Size(800, 562);
            this.shockwaveFlash.TabIndex = 9;
            // 
            // closeTopButton
            // 
            this.closeTopButton.Image = global::KalOnlineLauncher.Properties.Resources.close_top;
            this.closeTopButton.Location = new System.Drawing.Point(811, 11);
            this.closeTopButton.Name = "closeTopButton";
            this.closeTopButton.Size = new System.Drawing.Size(18, 18);
            this.closeTopButton.TabIndex = 4;
            this.closeTopButton.TabStop = false;
            this.closeTopButton.Click += new System.EventHandler(this.closeTopButton_Click);
            // 
            // closeBottomButton
            // 
            this.closeBottomButton.Image = global::KalOnlineLauncher.Properties.Resources.close_bottom;
            this.closeBottomButton.Location = new System.Drawing.Point(778, 641);
            this.closeBottomButton.Name = "closeBottomButton";
            this.closeBottomButton.Size = new System.Drawing.Size(23, 23);
            this.closeBottomButton.TabIndex = 3;
            this.closeBottomButton.TabStop = false;
            this.closeBottomButton.Click += new System.EventHandler(this.closeBottomButton_Click);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Image = global::KalOnlineLauncher.Properties.Resources.layout;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(841, 670);
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPictureBox_MouseDown);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(385, 608);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(111, 30);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.Enabled = false;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(710, 608);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 30);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // supportButton
            // 
            this.supportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supportButton.BackgroundImage")));
            this.supportButton.FlatAppearance.BorderSize = 0;
            this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportButton.ForeColor = System.Drawing.Color.White;
            this.supportButton.Location = new System.Drawing.Point(268, 608);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(111, 30);
            this.supportButton.TabIndex = 7;
            this.supportButton.Text = "Support";
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // forumButton
            // 
            this.forumButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forumButton.BackgroundImage")));
            this.forumButton.FlatAppearance.BorderSize = 0;
            this.forumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forumButton.ForeColor = System.Drawing.Color.White;
            this.forumButton.Location = new System.Drawing.Point(151, 608);
            this.forumButton.Name = "forumButton";
            this.forumButton.Size = new System.Drawing.Size(111, 30);
            this.forumButton.TabIndex = 6;
            this.forumButton.Text = "Forum";
            this.forumButton.UseVisualStyleBackColor = true;
            this.forumButton.Click += new System.EventHandler(this.forumButton_Click);
            // 
            // websiteButton
            // 
            this.websiteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("websiteButton.BackgroundImage")));
            this.websiteButton.FlatAppearance.BorderSize = 0;
            this.websiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteButton.ForeColor = System.Drawing.Color.White;
            this.websiteButton.Location = new System.Drawing.Point(34, 608);
            this.websiteButton.Name = "websiteButton";
            this.websiteButton.Size = new System.Drawing.Size(111, 30);
            this.websiteButton.TabIndex = 5;
            this.websiteButton.Text = "Website";
            this.websiteButton.UseVisualStyleBackColor = true;
            this.websiteButton.Click += new System.EventHandler(this.websiteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 670);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.shockwaveFlash);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.forumButton);
            this.Controls.Add(this.websiteButton);
            this.Controls.Add(this.closeTopButton);
            this.Controls.Add(this.closeBottomButton);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.backgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Long Cat Kal";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.shockwaveFlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeTopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBottomButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox closeBottomButton;
        private System.Windows.Forms.PictureBox closeTopButton;
        private KalButton websiteButton;
        private KalButton forumButton;
        private KalButton supportButton;
        private KalButton startButton;
        private AxShockwaveFlashObjects.AxShockwaveFlash shockwaveFlash;
        private KalButton settingsButton;

    }
}

