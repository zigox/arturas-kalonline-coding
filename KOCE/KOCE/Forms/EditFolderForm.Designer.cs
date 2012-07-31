namespace KOCE
{
    partial class EditFolderForm
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
            this.directoryGroupBox = new System.Windows.Forms.GroupBox();
            this.browseDirectoryButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.editorsGroupBox = new System.Windows.Forms.GroupBox();
            this.editEditorButton = new System.Windows.Forms.Button();
            this.addEditorButton = new System.Windows.Forms.Button();
            this.removeEditorButton = new System.Windows.Forms.Button();
            this.editorsListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.directoryGroupBox.SuspendLayout();
            this.editorsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoryGroupBox
            // 
            this.directoryGroupBox.Controls.Add(this.browseDirectoryButton);
            this.directoryGroupBox.Controls.Add(this.directoryTextBox);
            this.directoryGroupBox.Location = new System.Drawing.Point(12, 65);
            this.directoryGroupBox.Name = "directoryGroupBox";
            this.directoryGroupBox.Size = new System.Drawing.Size(479, 48);
            this.directoryGroupBox.TabIndex = 0;
            this.directoryGroupBox.TabStop = false;
            this.directoryGroupBox.Text = "Directory";
            // 
            // browseDirectoryButton
            // 
            this.browseDirectoryButton.Location = new System.Drawing.Point(398, 17);
            this.browseDirectoryButton.Name = "browseDirectoryButton";
            this.browseDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.browseDirectoryButton.TabIndex = 1;
            this.browseDirectoryButton.Text = "Browse";
            this.browseDirectoryButton.UseVisualStyleBackColor = true;
            this.browseDirectoryButton.Click += new System.EventHandler(this.browseDirectoryButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(6, 19);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(386, 20);
            this.directoryTextBox.TabIndex = 0;
            // 
            // editorsGroupBox
            // 
            this.editorsGroupBox.Controls.Add(this.editEditorButton);
            this.editorsGroupBox.Controls.Add(this.addEditorButton);
            this.editorsGroupBox.Controls.Add(this.removeEditorButton);
            this.editorsGroupBox.Controls.Add(this.editorsListBox);
            this.editorsGroupBox.Location = new System.Drawing.Point(12, 119);
            this.editorsGroupBox.Name = "editorsGroupBox";
            this.editorsGroupBox.Size = new System.Drawing.Size(479, 206);
            this.editorsGroupBox.TabIndex = 1;
            this.editorsGroupBox.TabStop = false;
            this.editorsGroupBox.Text = "Editors";
            // 
            // editEditorButton
            // 
            this.editEditorButton.Location = new System.Drawing.Point(398, 172);
            this.editEditorButton.Name = "editEditorButton";
            this.editEditorButton.Size = new System.Drawing.Size(75, 23);
            this.editEditorButton.TabIndex = 6;
            this.editEditorButton.Text = "Edit";
            this.editEditorButton.UseVisualStyleBackColor = true;
            this.editEditorButton.Click += new System.EventHandler(this.editEditorButton_Click);
            // 
            // addEditorButton
            // 
            this.addEditorButton.Location = new System.Drawing.Point(236, 172);
            this.addEditorButton.Name = "addEditorButton";
            this.addEditorButton.Size = new System.Drawing.Size(75, 23);
            this.addEditorButton.TabIndex = 5;
            this.addEditorButton.Text = "Add";
            this.addEditorButton.UseVisualStyleBackColor = true;
            this.addEditorButton.Click += new System.EventHandler(this.addEditorButton_Click);
            // 
            // removeEditorButton
            // 
            this.removeEditorButton.Location = new System.Drawing.Point(317, 172);
            this.removeEditorButton.Name = "removeEditorButton";
            this.removeEditorButton.Size = new System.Drawing.Size(75, 23);
            this.removeEditorButton.TabIndex = 4;
            this.removeEditorButton.Text = "Remove";
            this.removeEditorButton.UseVisualStyleBackColor = true;
            this.removeEditorButton.Click += new System.EventHandler(this.removeEditorButton_Click);
            // 
            // editorsListBox
            // 
            this.editorsListBox.FormattingEnabled = true;
            this.editorsListBox.Location = new System.Drawing.Point(6, 19);
            this.editorsListBox.Name = "editorsListBox";
            this.editorsListBox.Size = new System.Drawing.Size(467, 147);
            this.editorsListBox.TabIndex = 0;
            this.editorsListBox.DoubleClick += new System.EventHandler(this.editorsListBox_DoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(416, 331);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(467, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // EditFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editorsGroupBox);
            this.Controls.Add(this.directoryGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFolderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Folder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFolderForm_FormClosing);
            this.directoryGroupBox.ResumeLayout(false);
            this.directoryGroupBox.PerformLayout();
            this.editorsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox directoryGroupBox;
        private System.Windows.Forms.Button browseDirectoryButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox editorsGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox editorsListBox;
        private System.Windows.Forms.Button addEditorButton;
        private System.Windows.Forms.Button removeEditorButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button editEditorButton;
    }
}