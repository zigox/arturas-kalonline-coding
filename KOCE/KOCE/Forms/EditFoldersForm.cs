using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KOCE
{
    public partial class EditFoldersForm : Form
    {
        List<ProjectFolder> Folders;

        public EditFoldersForm(List<ProjectFolder> Folders)
        {
            InitializeComponent();
            this.Folders = Folders;

            PopulateList();
        }

        private void PopulateList()
        {
            folderListBox.Items.Clear();

            folderListBox.Items.AddRange(Folders.ToArray());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds a new folder.
        /// </summary>
        private void AddFolder()
        {
            ProjectFolder newFolder = new ProjectFolder("","");

            Folders.Add(newFolder);

            folderListBox.Items.Add(newFolder);

            folderListBox.SelectedItem = newFolder;

            EditFolder();
        }

        /// <summary>
        /// Edits the currently selected folder.
        /// </summary>
        private void EditFolder()
        {
            if (folderListBox.SelectedItem != null)
            {
                ProjectFolder selectedFolder = folderListBox.SelectedItem as ProjectFolder;

                EditFolderForm eff = new EditFolderForm(selectedFolder);

                eff.ShowDialog();

                PopulateList();
            }
        }

        /// <summary>
        /// Removes the currently selected folder.
        /// </summary>
        private void RemoveFolder()
        {
            if (folderListBox.SelectedItem != null)
            {
                ProjectFolder selectedFolder = folderListBox.SelectedItem as ProjectFolder;

                DialogResult result = MessageBox.Show("Are you sure you wish to remove this folder?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    folderListBox.Items.Remove(selectedFolder);
                    Folders.Remove(selectedFolder);
                }
            }
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            AddFolder();
        }

        private void removeFolderButton_Click(object sender, EventArgs e)
        {
            RemoveFolder();
        }

        private void editFolderButton_Click(object sender, EventArgs e)
        {
            EditFolder();
        }

        private void folderListBox_DoubleClick(object sender, EventArgs e)
        {
            EditFolder();
        }
    }
}
