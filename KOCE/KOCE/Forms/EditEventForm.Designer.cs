namespace KOCE
{
    partial class EditEventForm
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
            this.dInfoButton = new System.Windows.Forms.Button();
            this.wInfoButton = new System.Windows.Forms.Button();
            this.saInfoButton = new System.Windows.Forms.Button();
            this.browseProgramButton = new System.Windows.Forms.Button();
            this.delayNumeric = new System.Windows.Forms.NumericUpDown();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.startArgsTextBox = new System.Windows.Forms.TextBox();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dInfoButton);
            this.groupBox1.Controls.Add(this.wInfoButton);
            this.groupBox1.Controls.Add(this.saInfoButton);
            this.groupBox1.Controls.Add(this.browseProgramButton);
            this.groupBox1.Controls.Add(this.delayNumeric);
            this.groupBox1.Controls.Add(this.weightNumeric);
            this.groupBox1.Controls.Add(this.startArgsTextBox);
            this.groupBox1.Controls.Add(this.programTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event";
            // 
            // dInfoButton
            // 
            this.dInfoButton.Location = new System.Drawing.Point(420, 88);
            this.dInfoButton.Name = "dInfoButton";
            this.dInfoButton.Size = new System.Drawing.Size(27, 23);
            this.dInfoButton.TabIndex = 11;
            this.dInfoButton.Text = "?";
            this.dInfoButton.UseVisualStyleBackColor = true;
            this.dInfoButton.Click += new System.EventHandler(this.dInfoButton_Click);
            // 
            // wInfoButton
            // 
            this.wInfoButton.Location = new System.Drawing.Point(420, 62);
            this.wInfoButton.Name = "wInfoButton";
            this.wInfoButton.Size = new System.Drawing.Size(27, 23);
            this.wInfoButton.TabIndex = 10;
            this.wInfoButton.Text = "?";
            this.wInfoButton.UseVisualStyleBackColor = true;
            this.wInfoButton.Click += new System.EventHandler(this.wInfoButton_Click);
            // 
            // saInfoButton
            // 
            this.saInfoButton.Location = new System.Drawing.Point(420, 37);
            this.saInfoButton.Name = "saInfoButton";
            this.saInfoButton.Size = new System.Drawing.Size(27, 23);
            this.saInfoButton.TabIndex = 9;
            this.saInfoButton.Text = "?";
            this.saInfoButton.UseVisualStyleBackColor = true;
            this.saInfoButton.Click += new System.EventHandler(this.saInfoButton_Click);
            // 
            // browseProgramButton
            // 
            this.browseProgramButton.Location = new System.Drawing.Point(420, 11);
            this.browseProgramButton.Name = "browseProgramButton";
            this.browseProgramButton.Size = new System.Drawing.Size(75, 23);
            this.browseProgramButton.TabIndex = 8;
            this.browseProgramButton.Text = "Browse";
            this.browseProgramButton.UseVisualStyleBackColor = true;
            this.browseProgramButton.Click += new System.EventHandler(this.browseProgramButton_Click);
            // 
            // delayNumeric
            // 
            this.delayNumeric.Location = new System.Drawing.Point(94, 91);
            this.delayNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.delayNumeric.Name = "delayNumeric";
            this.delayNumeric.Size = new System.Drawing.Size(320, 20);
            this.delayNumeric.TabIndex = 7;
            // 
            // weightNumeric
            // 
            this.weightNumeric.Location = new System.Drawing.Point(94, 65);
            this.weightNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(320, 20);
            this.weightNumeric.TabIndex = 6;
            // 
            // startArgsTextBox
            // 
            this.startArgsTextBox.Location = new System.Drawing.Point(94, 39);
            this.startArgsTextBox.Name = "startArgsTextBox";
            this.startArgsTextBox.Size = new System.Drawing.Size(320, 20);
            this.startArgsTextBox.TabIndex = 5;
            // 
            // programTextBox
            // 
            this.programTextBox.Location = new System.Drawing.Point(94, 13);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Size = new System.Drawing.Size(320, 20);
            this.programTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Arguments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(438, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Executable files|*.exe|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 176);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEventForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditEventForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dInfoButton;
        private System.Windows.Forms.Button wInfoButton;
        private System.Windows.Forms.Button saInfoButton;
        private System.Windows.Forms.Button browseProgramButton;
        private System.Windows.Forms.NumericUpDown delayNumeric;
        private System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.TextBox startArgsTextBox;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}