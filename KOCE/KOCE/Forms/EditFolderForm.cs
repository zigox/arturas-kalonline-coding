using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KOCE
{
    public partial class EditFolderForm : Form
    {
        public ProjectFolder Folder;

        public EditFolderForm(ProjectFolder Folder)
        {
            InitializeComponent();
            this.Folder = Folder;

            LoadFolder();
        }

        private void LoadFolder()
        {
            nameTextBox.Text = Folder.Name;
            directoryTextBox.Text = Folder.DirectoryName;

            PopulateEditorList();
        }

        private void PopulateEditorList()
        {
            editorsListBox.Items.Clear();

            editorsListBox.Items.AddRange(Folder.Editors.ToArray());
        }

        private void browseDirectoryButton_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.SelectedPath = directoryTextBox.Text;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds a new editor.
        /// </summary>
        private void AddEditor()
        {
            ProjectFolderEditor newEditor = new ProjectFolderEditor("", "", "");

            Folder.Editors.Add(newEditor);

            editorsListBox.Items.Add(newEditor);

            editorsListBox.SelectedItem = newEditor;

            EditEditor();
        }

        /// <summary>
        /// Edits the currently selected editor.
        /// </summary>
        private void EditEditor()
        {
            if (editorsListBox.SelectedItem != null)
            {
                ProjectFolderEditor selectedEditor = editorsListBox.SelectedItem as ProjectFolderEditor;

                EditEditorForm eef = new EditEditorForm(selectedEditor);

                eef.ShowDialog();

                PopulateEditorList();
            }
        }

        /// <summary>
        /// Removes the currently selected editor.
        /// </summary>
        private void RemoveEditor()
        {
            if (editorsListBox.SelectedItem != null)
            {
                ProjectFolderEditor selectedEditor = editorsListBox.SelectedItem as ProjectFolderEditor;

                DialogResult result = MessageBox.Show("Are you sure you wish to remove this editor?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    editorsListBox.Items.Remove(selectedEditor);
                    Folder.Editors.Remove(selectedEditor);
                }
            }
        }

        private void addEditorButton_Click(object sender, EventArgs e)
        {
            AddEditor();
        }

        private void removeEditorButton_Click(object sender, EventArgs e)
        {
            RemoveEditor();
        }

        private void editEditorButton_Click(object sender, EventArgs e)
        {
            EditEditor();
        }

        private void EditFolderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Folder.Name = nameTextBox.Text;
            Folder.DirectoryName = directoryTextBox.Text;
        }

        private void editorsListBox_DoubleClick(object sender, EventArgs e)
        {
            EditEditor();
        }

    }
}
