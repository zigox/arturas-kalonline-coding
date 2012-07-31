namespace KOCE
{
    partial class EditFoldersForm
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
            this.folderListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.editFolderButton = new System.Windows.Forms.Button();
            this.removeFolderButton = new System.Windows.Forms.Button();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderListBox
            // 
            this.folderListBox.FormattingEnabled = true;
            this.folderListBox.Location = new System.Drawing.Point(6, 19);
            this.folderListBox.Name = "folderListBox";
            this.folderListBox.Size = new System.Drawing.Size(417, 264);
            this.folderListBox.TabIndex = 0;
            this.folderListBox.DoubleClick += new System.EventHandler(this.folderListBox_DoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(366, 332);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editFolderButton
            // 
            this.editFolderButton.Location = new System.Drawing.Point(348, 285);
            this.editFolderButton.Name = "editFolderButton";
            this.editFolderButton.Size = new System.Drawing.Size(75, 23);
            this.editFolderButton.TabIndex = 2;
            this.editFolderButton.Text = "Edit";
            this.editFolderButton.UseVisualStyleBackColor = true;
            this.editFolderButton.Click += new System.EventHandler(this.editFolderButton_Click);
            // 
            // removeFolderButton
            // 
            this.removeFolderButton.Location = new System.Drawing.Point(267, 285);
            this.removeFolderButton.Name = "removeFolderButton";
            this.removeFolderButton.Size = new System.Drawing.Size(75, 23);
            this.removeFolderButton.TabIndex = 3;
            this.removeFolderButton.Text = "Remove";
            this.removeFolderButton.UseVisualStyleBackColor = true;
            this.removeFolderButton.Click += new System.EventHandler(this.removeFolderButton_Click);
            // 
            // addFolderButton
            // 
            this.addFolderButton.Location = new System.Drawing.Point(186, 285);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(75, 23);
            this.addFolderButton.TabIndex = 4;
            this.addFolderButton.Text = "Add";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.addFolderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderListBox);
            this.groupBox1.Controls.Add(this.addFolderButton);
            this.groupBox1.Controls.Add(this.editFolderButton);
            this.groupBox1.Controls.Add(this.removeFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // EditFoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFoldersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Folders";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox folderListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button editFolderButton;
        private System.Windows.Forms.Button removeFolderButton;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}