namespace SharekalItemUpdate
{
    partial class UpdateItemsForm
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
            this.openInitItemButton = new System.Windows.Forms.Button();
            this.openMessageEButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.openMessageEDialog = new System.Windows.Forms.OpenFileDialog();
            this.openInitItemDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openInitItemButton
            // 
            this.openInitItemButton.Location = new System.Drawing.Point(12, 12);
            this.openInitItemButton.Name = "openInitItemButton";
            this.openInitItemButton.Size = new System.Drawing.Size(224, 23);
            this.openInitItemButton.TabIndex = 0;
            this.openInitItemButton.Text = "Open Inititem";
            this.openInitItemButton.UseVisualStyleBackColor = true;
            this.openInitItemButton.Click += new System.EventHandler(this.openInitItemButton_Click);
            // 
            // openMessageEButton
            // 
            this.openMessageEButton.Enabled = false;
            this.openMessageEButton.Location = new System.Drawing.Point(12, 41);
            this.openMessageEButton.Name = "openMessageEButton";
            this.openMessageEButton.Size = new System.Drawing.Size(224, 23);
            this.openMessageEButton.TabIndex = 1;
            this.openMessageEButton.Text = "Open Message-E";
            this.openMessageEButton.UseVisualStyleBackColor = true;
            this.openMessageEButton.Click += new System.EventHandler(this.openMessageEButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(12, 70);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(224, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // openMessageEDialog
            // 
            this.openMessageEDialog.FileName = "Message-e.dat";
            this.openMessageEDialog.Filter = "Text files|*.txt|All files|*.*";
            this.openMessageEDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openMessageEDialog_FileOk);
            // 
            // openInitItemDialog
            // 
            this.openInitItemDialog.FileName = "InitItem.txt";
            this.openInitItemDialog.Filter = "Text files|*.txt|All files|*.*";
            this.openInitItemDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openInitItemDialog_FileOk);
            // 
            // UpdateItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 103);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.openMessageEButton);
            this.Controls.Add(this.openInitItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateItemsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openInitItemButton;
        private System.Windows.Forms.Button openMessageEButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.OpenFileDialog openMessageEDialog;
        private System.Windows.Forms.OpenFileDialog openInitItemDialog;
    }
}

