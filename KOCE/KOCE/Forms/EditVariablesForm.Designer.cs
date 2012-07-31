namespace KOCE
{
    partial class EditVariablesForm
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
            this.addVariableButton = new System.Windows.Forms.Button();
            this.removeVariableButton = new System.Windows.Forms.Button();
            this.editVariableButton = new System.Windows.Forms.Button();
            this.variablesListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addVariableButton);
            this.groupBox1.Controls.Add(this.removeVariableButton);
            this.groupBox1.Controls.Add(this.editVariableButton);
            this.groupBox1.Controls.Add(this.variablesListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables";
            // 
            // addVariableButton
            // 
            this.addVariableButton.Location = new System.Drawing.Point(152, 293);
            this.addVariableButton.Name = "addVariableButton";
            this.addVariableButton.Size = new System.Drawing.Size(75, 23);
            this.addVariableButton.TabIndex = 3;
            this.addVariableButton.Text = "Add";
            this.addVariableButton.UseVisualStyleBackColor = true;
            this.addVariableButton.Click += new System.EventHandler(this.addVariableButton_Click);
            // 
            // removeVariableButton
            // 
            this.removeVariableButton.Location = new System.Drawing.Point(233, 293);
            this.removeVariableButton.Name = "removeVariableButton";
            this.removeVariableButton.Size = new System.Drawing.Size(75, 23);
            this.removeVariableButton.TabIndex = 2;
            this.removeVariableButton.Text = "Remove";
            this.removeVariableButton.UseVisualStyleBackColor = true;
            this.removeVariableButton.Click += new System.EventHandler(this.removeVariableButton_Click);
            // 
            // editVariableButton
            // 
            this.editVariableButton.Location = new System.Drawing.Point(314, 293);
            this.editVariableButton.Name = "editVariableButton";
            this.editVariableButton.Size = new System.Drawing.Size(75, 23);
            this.editVariableButton.TabIndex = 1;
            this.editVariableButton.Text = "Edit";
            this.editVariableButton.UseVisualStyleBackColor = true;
            this.editVariableButton.Click += new System.EventHandler(this.editVariableButton_Click);
            // 
            // variablesListBox
            // 
            this.variablesListBox.FormattingEnabled = true;
            this.variablesListBox.Location = new System.Drawing.Point(6, 19);
            this.variablesListBox.Name = "variablesListBox";
            this.variablesListBox.Size = new System.Drawing.Size(383, 264);
            this.variablesListBox.TabIndex = 0;
            this.variablesListBox.DoubleClick += new System.EventHandler(this.variablesListBox_DoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(332, 340);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditVariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 375);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditVariablesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Variables";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addVariableButton;
        private System.Windows.Forms.Button removeVariableButton;
        private System.Windows.Forms.Button editVariableButton;
        private System.Windows.Forms.ListBox variablesListBox;
        private System.Windows.Forms.Button closeButton;
    }
}