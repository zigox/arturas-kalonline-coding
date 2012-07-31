namespace KOCE
{
    partial class EditBuildGroupsForm
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
            this.addBuildGroupButton = new System.Windows.Forms.Button();
            this.removeBuildGroupButton = new System.Windows.Forms.Button();
            this.editBuildGroupButton = new System.Windows.Forms.Button();
            this.buildGroupListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBuildGroupButton);
            this.groupBox1.Controls.Add(this.removeBuildGroupButton);
            this.groupBox1.Controls.Add(this.editBuildGroupButton);
            this.groupBox1.Controls.Add(this.buildGroupListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Groups";
            // 
            // addBuildGroupButton
            // 
            this.addBuildGroupButton.Location = new System.Drawing.Point(151, 195);
            this.addBuildGroupButton.Name = "addBuildGroupButton";
            this.addBuildGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addBuildGroupButton.TabIndex = 3;
            this.addBuildGroupButton.Text = "Add";
            this.addBuildGroupButton.UseVisualStyleBackColor = true;
            this.addBuildGroupButton.Click += new System.EventHandler(this.addBuildGroupButton_Click);
            // 
            // removeBuildGroupButton
            // 
            this.removeBuildGroupButton.Location = new System.Drawing.Point(232, 195);
            this.removeBuildGroupButton.Name = "removeBuildGroupButton";
            this.removeBuildGroupButton.Size = new System.Drawing.Size(75, 23);
            this.removeBuildGroupButton.TabIndex = 2;
            this.removeBuildGroupButton.Text = "Remove";
            this.removeBuildGroupButton.UseVisualStyleBackColor = true;
            this.removeBuildGroupButton.Click += new System.EventHandler(this.removeBuildGroupButton_Click);
            // 
            // editBuildGroupButton
            // 
            this.editBuildGroupButton.Location = new System.Drawing.Point(313, 195);
            this.editBuildGroupButton.Name = "editBuildGroupButton";
            this.editBuildGroupButton.Size = new System.Drawing.Size(75, 23);
            this.editBuildGroupButton.TabIndex = 1;
            this.editBuildGroupButton.Text = "Edit";
            this.editBuildGroupButton.UseVisualStyleBackColor = true;
            this.editBuildGroupButton.Click += new System.EventHandler(this.editBuildGroupButton_Click);
            // 
            // buildGroupListBox
            // 
            this.buildGroupListBox.FormattingEnabled = true;
            this.buildGroupListBox.Location = new System.Drawing.Point(6, 19);
            this.buildGroupListBox.Name = "buildGroupListBox";
            this.buildGroupListBox.Size = new System.Drawing.Size(382, 173);
            this.buildGroupListBox.TabIndex = 0;
            this.buildGroupListBox.DoubleClick += new System.EventHandler(this.buildGroupListBox_DoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(331, 242);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditBuildGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 277);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBuildGroupsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Build Groups";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBuildGroupButton;
        private System.Windows.Forms.Button removeBuildGroupButton;
        private System.Windows.Forms.Button editBuildGroupButton;
        private System.Windows.Forms.ListBox buildGroupListBox;
        private System.Windows.Forms.Button closeButton;
    }
}