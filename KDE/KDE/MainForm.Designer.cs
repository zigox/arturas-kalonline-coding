namespace ArturasServer.KalOnline.DataEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.objectClassListView = new ArturasServer.KalOnline.DataEditor.ObjectClassListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectClassIcons = new System.Windows.Forms.ImageList(this.components);
            this.objectClassesToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.searchObjectsTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.dataFileComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.objectLinksListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linksToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.openProjectDialog = new System.Windows.Forms.OpenFileDialog();
            this.updateObjectListBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.objectClassesToolStrip.SuspendLayout();
            this.linksToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 540);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(784, 25);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(784, 491);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.objectClassListView);
            this.splitContainer2.Panel1.Controls.Add(this.objectClassesToolStrip);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.objectLinksListView);
            this.splitContainer2.Panel2.Controls.Add(this.linksToolStrip);
            this.splitContainer2.Size = new System.Drawing.Size(376, 491);
            this.splitContainer2.SplitterDistance = 259;
            this.splitContainer2.TabIndex = 0;
            // 
            // objectClassListView
            // 
            this.objectClassListView.AllowColumnReorder = true;
            this.objectClassListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.objectClassListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectClassListView.FullRowSelect = true;
            this.objectClassListView.GridLines = true;
            this.objectClassListView.HideSelection = false;
            this.objectClassListView.Location = new System.Drawing.Point(0, 25);
            this.objectClassListView.Name = "objectClassListView";
            this.objectClassListView.ObjectLinksListView = null;
            this.objectClassListView.PropertyGrid = null;
            this.objectClassListView.ShowItemToolTips = true;
            this.objectClassListView.Size = new System.Drawing.Size(372, 230);
            this.objectClassListView.SmallImageList = this.objectClassIcons;
            this.objectClassListView.TabIndex = 1;
            this.objectClassListView.UseCompatibleStateImageBehavior = false;
            this.objectClassListView.View = System.Windows.Forms.View.Details;
            this.objectClassListView.VirtualMode = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Object";
            this.columnHeader1.Width = 169;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data File";
            this.columnHeader3.Width = 118;
            // 
            // objectClassIcons
            // 
            this.objectClassIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("objectClassIcons.ImageStream")));
            this.objectClassIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.objectClassIcons.Images.SetKeyName(0, "Monster");
            this.objectClassIcons.Images.SetKeyName(1, "MonsterName");
            this.objectClassIcons.Images.SetKeyName(2, "GenMonster");
            // 
            // objectClassesToolStrip
            // 
            this.objectClassesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.searchObjectsTextbox,
            this.dataFileComboBox});
            this.objectClassesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.objectClassesToolStrip.Name = "objectClassesToolStrip";
            this.objectClassesToolStrip.Size = new System.Drawing.Size(372, 25);
            this.objectClassesToolStrip.TabIndex = 0;
            this.objectClassesToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel2.Text = "Search Objects";
            // 
            // searchObjectsTextbox
            // 
            this.searchObjectsTextbox.Name = "searchObjectsTextbox";
            this.searchObjectsTextbox.Size = new System.Drawing.Size(150, 25);
            this.searchObjectsTextbox.TextChanged += new System.EventHandler(this.searchObjectsTextbox_TextChanged);
            // 
            // dataFileComboBox
            // 
            this.dataFileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataFileComboBox.DropDownWidth = 400;
            this.dataFileComboBox.Name = "dataFileComboBox";
            this.dataFileComboBox.Size = new System.Drawing.Size(121, 25);
            this.dataFileComboBox.SelectedIndexChanged += new System.EventHandler(this.dataFileComboBox_SelectedIndexChanged);
            // 
            // objectLinksListView
            // 
            this.objectLinksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.objectLinksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectLinksListView.Location = new System.Drawing.Point(0, 25);
            this.objectLinksListView.MultiSelect = false;
            this.objectLinksListView.Name = "objectLinksListView";
            this.objectLinksListView.ShowItemToolTips = true;
            this.objectLinksListView.Size = new System.Drawing.Size(372, 199);
            this.objectLinksListView.SmallImageList = this.objectClassIcons;
            this.objectLinksListView.TabIndex = 0;
            this.objectLinksListView.UseCompatibleStateImageBehavior = false;
            this.objectLinksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Object";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data File";
            this.columnHeader6.Width = 119;
            // 
            // linksToolStrip
            // 
            this.linksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.linksToolStrip.Location = new System.Drawing.Point(0, 0);
            this.linksToolStrip.Name = "linksToolStrip";
            this.linksToolStrip.Size = new System.Drawing.Size(372, 25);
            this.linksToolStrip.TabIndex = 1;
            this.linksToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Links";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(400, 487);
            this.propertyGrid.TabIndex = 0;
            // 
            // searchTimer
            // 
            this.searchTimer.Interval = 10;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // saveProjectDialog
            // 
            this.saveProjectDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveProjectDialog_FileOk);
            // 
            // openProjectDialog
            // 
            this.openProjectDialog.FileName = "openFileDialog1";
            this.openProjectDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openProjectDialog_FileOk);
            // 
            // updateObjectListBackgroundWorker
            // 
            this.updateObjectListBackgroundWorker.WorkerSupportsCancellation = true;
            this.updateObjectListBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateObjectListBackgroundWorker_DoWork);
            this.updateObjectListBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateObjectListBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "KalOnline Data Editor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.objectClassesToolStrip.ResumeLayout(false);
            this.objectClassesToolStrip.PerformLayout();
            this.linksToolStrip.ResumeLayout(false);
            this.linksToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private ArturasServer.KalOnline.DataEditor.ObjectClassListView objectClassListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip objectClassesToolStrip;
        private System.Windows.Forms.ToolStrip linksToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchObjectsTextbox;
        private System.Windows.Forms.ToolStripComboBox dataFileComboBox;
        private System.Windows.Forms.ListView objectLinksListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.ImageList objectClassIcons;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveProjectDialog;
        private System.Windows.Forms.OpenFileDialog openProjectDialog;
        private System.ComponentModel.BackgroundWorker updateObjectListBackgroundWorker;
    }
}

