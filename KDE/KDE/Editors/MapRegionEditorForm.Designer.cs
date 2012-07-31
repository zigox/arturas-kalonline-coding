namespace ArturasServer.KalOnline.DataEditor.Editors
{
    partial class MapRegionEditorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mapDropDown = new System.Windows.Forms.ComboBox();
            this.positionGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.y1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.y2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mapRegionControl = new ArturasServer.KalOnline.DataEditor.XNAGraphics.MapRegionControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mapGroupBox.SuspendLayout();
            this.positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.positionGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.mapGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapRegionControl);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.mapDropDown);
            this.mapGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(188, 44);
            this.mapGroupBox.TabIndex = 2;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Display Map";
            // 
            // mapDropDown
            // 
            this.mapDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapDropDown.FormattingEnabled = true;
            this.mapDropDown.Location = new System.Drawing.Point(6, 17);
            this.mapDropDown.Name = "mapDropDown";
            this.mapDropDown.Size = new System.Drawing.Size(176, 21);
            this.mapDropDown.TabIndex = 0;
            this.mapDropDown.SelectedIndexChanged += new System.EventHandler(this.mapDropDown_SelectedIndexChanged);
            // 
            // positionGroupBox
            // 
            this.positionGroupBox.Controls.Add(this.label4);
            this.positionGroupBox.Controls.Add(this.label3);
            this.positionGroupBox.Controls.Add(this.label2);
            this.positionGroupBox.Controls.Add(this.y2NumericUpDown);
            this.positionGroupBox.Controls.Add(this.x2NumericUpDown);
            this.positionGroupBox.Controls.Add(this.y1NumericUpDown);
            this.positionGroupBox.Controls.Add(this.x1NumericUpDown);
            this.positionGroupBox.Controls.Add(this.label1);
            this.positionGroupBox.Location = new System.Drawing.Point(12, 62);
            this.positionGroupBox.Name = "positionGroupBox";
            this.positionGroupBox.Size = new System.Drawing.Size(188, 120);
            this.positionGroupBox.TabIndex = 3;
            this.positionGroupBox.TabStop = false;
            this.positionGroupBox.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // x1NumericUpDown
            // 
            this.x1NumericUpDown.Location = new System.Drawing.Point(62, 14);
            this.x1NumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.x1NumericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.x1NumericUpDown.Name = "x1NumericUpDown";
            this.x1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.x1NumericUpDown.TabIndex = 1;
            this.x1NumericUpDown.ValueChanged += new System.EventHandler(this.x1NumericUpDown_ValueChanged);
            // 
            // y1NumericUpDown
            // 
            this.y1NumericUpDown.Location = new System.Drawing.Point(62, 40);
            this.y1NumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.y1NumericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.y1NumericUpDown.Name = "y1NumericUpDown";
            this.y1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.y1NumericUpDown.TabIndex = 2;
            this.y1NumericUpDown.ValueChanged += new System.EventHandler(this.y1NumericUpDown_ValueChanged);
            // 
            // x2NumericUpDown
            // 
            this.x2NumericUpDown.Location = new System.Drawing.Point(62, 66);
            this.x2NumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.x2NumericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.x2NumericUpDown.Name = "x2NumericUpDown";
            this.x2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.x2NumericUpDown.TabIndex = 3;
            this.x2NumericUpDown.ValueChanged += new System.EventHandler(this.x2NumericUpDown_ValueChanged);
            // 
            // y2NumericUpDown
            // 
            this.y2NumericUpDown.Location = new System.Drawing.Point(62, 92);
            this.y2NumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.y2NumericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.y2NumericUpDown.Name = "y2NumericUpDown";
            this.y2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.y2NumericUpDown.TabIndex = 4;
            this.y2NumericUpDown.ValueChanged += new System.EventHandler(this.y2NumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y2";
            // 
            // mapRegionControl
            // 
            this.mapRegionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapRegionControl.Location = new System.Drawing.Point(0, 0);
            this.mapRegionControl.Name = "mapRegionControl";
            this.mapRegionControl.Size = new System.Drawing.Size(570, 562);
            this.mapRegionControl.TabIndex = 0;
            this.mapRegionControl.Text = "mapRegionControl1";
            this.mapRegionControl.Click += new System.EventHandler(this.mapRegionControl_Click);
            // 
            // MapRegionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "MapRegionEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Region";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mapGroupBox.ResumeLayout(false);
            this.positionGroupBox.ResumeLayout(false);
            this.positionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArturasServer.KalOnline.DataEditor.XNAGraphics.MapRegionControl mapRegionControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox mapGroupBox;
        private System.Windows.Forms.GroupBox positionGroupBox;
        private System.Windows.Forms.ComboBox mapDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown y2NumericUpDown;
        private System.Windows.Forms.NumericUpDown x2NumericUpDown;
        private System.Windows.Forms.NumericUpDown y1NumericUpDown;
        private System.Windows.Forms.NumericUpDown x1NumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}