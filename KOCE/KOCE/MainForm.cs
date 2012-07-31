using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DDay.Update;

namespace KOCE
{
    public partial class MainForm : Form
    {
        Project CurrentProject;
        Builder LastBuilder;

        const string PROGRAM_NAME = "Kal Online Config Editor";

        public MainForm()
        {
            InitializeComponent();

            UpdateBootstrap();

            //args
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                OpenProject(args[1]);
            }

            UpdateName();
        }

        private void UpdateBootstrap()
        {
            try
            {
                UpdateManager.UpdateBootstrapFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating bootstrap:" + ex.Message);
            }
        }

        private void UpdateName()
        {
            if (CurrentProject != null)
            {
                this.Text = PROGRAM_NAME + " - " + CurrentProject.Name;
            }
            else
            {
                this.Text = PROGRAM_NAME;
            }
        }

        private void OpenProject()
        {
            openProjectFileDialog.ShowDialog();
        }

        private void OpenProject(string FileName)
        {
            try
            {
                Serializer ser = new Serializer();
                CurrentProject = ser.DeSerializeObject(FileName);

                LoadFolderList();
                LoadBuildGroupList();

                //enable toolbars etc
                buildToolStripMenuItem.Enabled = true;
                projectToolStripMenuItem.Enabled = true;
                mainToolStrip.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading project.");
            }
        }

        private void LoadFolderList()
        {
            selectFolderDropDown.Items.Clear();

            selectFolderDropDown.Items.AddRange(CurrentProject.Folders.ToArray());
        }

        private void LoadBuildGroupList()
        {
            buildGroupComboBox.Items.Clear();

            buildGroupComboBox.Items.AddRange(CurrentProject.BuildGroups.ToArray());
        }

        private ProjectFolder SelectedFolder
        {
            get
            {
                return selectFolderDropDown.SelectedItem as ProjectFolder;
            }
        }

        private void OpenFolder(string Filter)
        {
            if (SelectedFolder != null)
            {
                if (Directory.Exists(SelectedFolder.DirectoryName))
                {
                    DirectoryInfo di = new DirectoryInfo(SelectedFolder.DirectoryName);

                    //clear list
                    fileListView.Items.Clear();
                    //add to list
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if (fi.Name.ToLower().Contains(Filter.ToLower()))
                        {
                            fileListView.Items.Add(new FileListViewItem(fi.FullName));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Unable to find directory \"{0}\"", SelectedFolder.DirectoryName));
                }
            }
        }

        private void selectFolderDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFolder(searchToolStripTextBox.Text);
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            OpenFolder(searchToolStripTextBox.Text);
        }

        /// <summary>
        /// Opens the file with the editor specified in the project.
        /// </summary>
        /// <param name="FileName">The file to open.</param>
        private void OpenFile(string FileName)
        {
            if (SelectedFolder != null)
            {
                //get file info
                FileInfo fi = new FileInfo(FileName);

                //find the editor
                ProjectFolderEditor editor = SelectedFolder.FindEditor(fi.Extension);

                //get template
                StringTemplate template = new StringTemplate();

                //asign values
                AssignVariables(template);
                template.Assign("file_name", FileName);
                template.Assign("current_folder.path", SelectedFolder.DirectoryName);
                template.Assign("current_folder.name", SelectedFolder.Name);

                //start the process
                Process.Start(template.GetOutput(editor.Program), template.GetOutput(editor.CommandLineArguments));

            }

        }

        private void fileListView_ItemActivate(object sender, EventArgs e)
        {
            FileListViewItem selectedItem = fileListView.SelectedItems[0] as FileListViewItem;
            OpenFile(selectedItem.FileName);
        }

        private void EditFolders()
        {
            EditFoldersForm eff = new EditFoldersForm(CurrentProject.Folders);
            eff.ShowDialog();

            LoadFolderList();

            fileListView.Items.Clear();

            SaveProject();
        }

        private void EditBuildGroups()
        {
            EditBuildGroupsForm ebgf = new EditBuildGroupsForm(CurrentProject.BuildGroups);

            ebgf.ShowDialog();

            LoadBuildGroupList();

            SaveProject();
        }

        private void foldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFolders();
        }

        private void buildEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBuildGroups();
        }

        private ProjectBuildGroup SelectedBuildGroup
        {
            get
            {
                return buildGroupComboBox.SelectedItem as ProjectBuildGroup;
            }
        }

        private void AssignVariables(StringTemplate Template)
        {
            //datetime
            Template.Assign("datetime", DateTime.Now);

            //variables
            foreach (Variable var in CurrentProject.Variables)
            {
                //value
                Template.Assign(String.Format("variables[{0}].value", var.Key), var.Value);
            }

            //folders
            foreach (ProjectFolder folder in CurrentProject.Folders)
            {
                //folder directory
                Template.Assign(String.Format("folders[{0}].path", folder.Name), folder.DirectoryName);
            }
        }

        private void Build()
        {
            if (SelectedBuildGroup != null)
            {
                //create builder
                Builder builder = new Builder(SelectedBuildGroup);

                //assign variables

                AssignVariables(builder.Template);

                LastBuilder = builder;

                //being build
                builder.Build();

                
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Build();
        }

        private void EditVariables()
        {
            EditVariablesForm evf = new EditVariablesForm(CurrentProject.Variables);

            evf.ShowDialog();

            SaveProject();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditVariables();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void openProjectFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenProject(openProjectFileDialog.FileName);
        }

        private void KillBuild()
        {
            if (LastBuilder != null)
            {
                LastBuilder.KillAll();
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillBuild();
        }

        private void SaveProject()
        {
            if (CurrentProject != null)
            {
                Serializer ser = new Serializer();
                ser.SerializeObject(CurrentProject.FileName, CurrentProject);
            }
        }

        private void NewProject()
        {
            Project newProject = ProjectLoader.LoadProject(Application.StartupPath + "\\defaultproject.xml");

            newProject.FileName = saveProjectDialog.FileName;

            Serializer ser = new Serializer();
            ser.SerializeObject(saveProjectDialog.FileName, newProject);

            OpenProject(saveProjectDialog.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProjectDialog.ShowDialog();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProject();
        }

        private void saveProjectDialog_FileOk(object sender, CancelEventArgs e)
        {
            NewProject();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.arturasserver.com");
        }


    }
}
