namespace SharekalItemUpdate
{
    partial class EditShopItemsForm
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
            this.shopItemsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shopItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.serverComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.updateItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopItemsPropertyGrid
            // 
            this.shopItemsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopItemsPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.shopItemsPropertyGrid.Name = "shopItemsPropertyGrid";
            this.shopItemsPropertyGrid.Size = new System.Drawing.Size(1029, 290);
            this.shopItemsPropertyGrid.TabIndex = 0;
            this.shopItemsPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.shopItemsPropertyGrid_PropertyValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.shopItemsListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.itemsListBox);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 297);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 2;
            // 
            // shopItemsListView
            // 
            this.shopItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.shopItemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopItemsListView.FullRowSelect = true;
            this.shopItemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.shopItemsListView.Location = new System.Drawing.Point(0, 0);
            this.shopItemsListView.Name = "shopItemsListView";
            this.shopItemsListView.Size = new System.Drawing.Size(531, 293);
            this.shopItemsListView.TabIndex = 0;
            this.shopItemsListView.UseCompatibleStateImageBehavior = false;
            this.shopItemsListView.View = System.Windows.Forms.View.Details;
            this.shopItemsListView.SelectedIndexChanged += new System.EventHandler(this.shopItemsListView_SelectedIndexChanged);
            this.shopItemsListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shopItemsListView_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Num";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Category";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(0, 0);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(490, 293);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.DoubleClick += new System.EventHandler(this.itemsListBox_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 27);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.shopItemsPropertyGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1033, 595);
            this.splitContainer2.SplitterDistance = 297;
            this.splitContainer2.TabIndex = 3;
            // 
            // serverComboBox
            // 
            this.serverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverComboBox.DropDownWidth = 250;
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(250, 23);
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged);
            // 
            // updateItemsToolStripMenuItem
            // 
            this.updateItemsToolStripMenuItem.Name = "updateItemsToolStripMenuItem";
            this.updateItemsToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.updateItemsToolStripMenuItem.Text = "Update Items";
            this.updateItemsToolStripMenuItem.Click += new System.EventHandler(this.updateItemsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverComboBox,
            this.updateItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditShopItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 622);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditShopItemsForm";
            this.Text = "Edit Shop Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditShopItemsForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView shopItemsListView;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PropertyGrid shopItemsPropertyGrid;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripComboBox serverComboBox;
        private System.Windows.Forms.ToolStripMenuItem updateItemsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}