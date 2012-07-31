namespace KOCE
{
    partial class EditBuildGroupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.removeEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(457, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eventsListBox);
            this.groupBox2.Controls.Add(this.addEventButton);
            this.groupBox2.Controls.Add(this.removeEventButton);
            this.groupBox2.Controls.Add(this.editEventButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Events";
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(6, 19);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(457, 173);
            this.eventsListBox.TabIndex = 3;
            this.eventsListBox.DoubleClick += new System.EventHandler(this.eventsListBox_DoubleClick);
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(226, 203);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 23);
            this.addEventButton.TabIndex = 2;
            this.addEventButton.Text = "Add";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // removeEventButton
            // 
            this.removeEventButton.Location = new System.Drawing.Point(307, 203);
            this.removeEventButton.Name = "removeEventButton";
            this.removeEventButton.Size = new System.Drawing.Size(75, 23);
            this.removeEventButton.TabIndex = 1;
            this.removeEventButton.Text = "Remove";
            this.removeEventButton.UseVisualStyleBackColor = true;
            this.removeEventButton.Click += new System.EventHandler(this.removeEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Location = new System.Drawing.Point(388, 203);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(75, 23);
            this.editEventButton.TabIndex = 0;
            this.editEventButton.Text = "Edit";
            this.editEventButton.UseVisualStyleBackColor = true;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(406, 302);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditBuildGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 337);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBuildGroupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Build Group";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditBuildGroupForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button removeEventButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button closeButton;
    }
}