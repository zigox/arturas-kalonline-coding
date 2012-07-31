namespace KOCE
{
    partial class EditEditorForm
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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extensionInfoButton = new System.Windows.Forms.Button();
            this.startArgsInfoButton = new System.Windows.Forms.Button();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.argsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseProgramButton = new System.Windows.Forms.Button();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.label3);
            this.settingsGroupBox.Controls.Add(this.extensionInfoButton);
            this.settingsGroupBox.Controls.Add(this.startArgsInfoButton);
            this.settingsGroupBox.Controls.Add(this.extensionTextBox);
            this.settingsGroupBox.Controls.Add(this.argsTextBox);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.browseProgramButton);
            this.settingsGroupBox.Controls.Add(this.programTextBox);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(473, 101);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Editor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extension";
            // 
            // extensionInfoButton
            // 
            this.extensionInfoButton.Location = new System.Drawing.Point(392, 68);
            this.extensionInfoButton.Name = "extensionInfoButton";
            this.extensionInfoButton.Size = new System.Drawing.Size(23, 23);
            this.extensionInfoButton.TabIndex = 7;
            this.extensionInfoButton.Text = "?";
            this.extensionInfoButton.UseVisualStyleBackColor = true;
            this.extensionInfoButton.Click += new System.EventHandler(this.extensionInfoButton_Click);
            // 
            // startArgsInfoButton
            // 
            this.startArgsInfoButton.Location = new System.Drawing.Point(392, 43);
            this.startArgsInfoButton.Name = "startArgsInfoButton";
            this.startArgsInfoButton.Size = new System.Drawing.Size(23, 23);
            this.startArgsInfoButton.TabIndex = 6;
            this.startArgsInfoButton.Text = "?";
            this.startArgsInfoButton.UseVisualStyleBackColor = true;
            this.startArgsInfoButton.Click += new System.EventHandler(this.startArgsInfoButton_Click);
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(109, 71);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(277, 20);
            this.extensionTextBox.TabIndex = 5;
            // 
            // argsTextBox
            // 
            this.argsTextBox.Location = new System.Drawing.Point(109, 45);
            this.argsTextBox.Name = "argsTextBox";
            this.argsTextBox.Size = new System.Drawing.Size(277, 20);
            this.argsTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Arguments";
            // 
            // browseProgramButton
            // 
            this.browseProgramButton.Location = new System.Drawing.Point(392, 17);
            this.browseProgramButton.Name = "browseProgramButton";
            this.browseProgramButton.Size = new System.Drawing.Size(75, 23);
            this.browseProgramButton.TabIndex = 2;
            this.browseProgramButton.Text = "Browse";
            this.browseProgramButton.UseVisualStyleBackColor = true;
            this.browseProgramButton.Click += new System.EventHandler(this.browseProgramButton_Click);
            // 
            // programTextBox
            // 
            this.programTextBox.Location = new System.Drawing.Point(109, 19);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Size = new System.Drawing.Size(277, 20);
            this.programTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(410, 119);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Executable files|*.exe|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EditEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 154);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.settingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditEditorForm_FormClosing);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button extensionInfoButton;
        private System.Windows.Forms.Button startArgsInfoButton;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox argsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseProgramButton;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}