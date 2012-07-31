using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArturasServer.KalOnline.Kml;
using ArturasServer.KalOnline.Kml.ObjectMapping;
using ArturasServer.KalOnline.Kml.Tools;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;
using ArturasServer.KalOnline.DataEditor.Editors;
using System.IO;

namespace ArturasServer.KalOnline.DataEditor
{
    public partial class MainForm : Form
    {
        public static Project CurrentProject;
        public static ImageList ObjectIcons;

        public MainForm()
        {
            InitializeComponent();

            ObjectIcons = objectClassIcons;

            //create a project
            Project newProject = new Project();
            newProject.Name = "Test Project";

            newProject.DataFiles.Add(new DataFile("Init Monster", @"J:\Kal Online\Server\Config\InitMonster.txt"));
            newProject.DataFiles.Add(new DataFile("Gen Monster", @"J:\Kal Online\Server\Config\GenMonster.txt"));
            newProject.DataFiles.Add(new DataFile("Init Item", @"J:\Kal Online\Server\Config\InitItem.txt"));
            newProject.DataFiles.Add(new DataFile("Message E", @"J:\Kal Online\message-e.txt"));

            CurrentProject = newProject;

            //load minimaps
            //MinimapLoader.LoadMaps();

            //begin deserializing lisp
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.ShowDialog();

            objectClassListView.PropertyGrid = propertyGrid;
            objectClassListView.ObjectLinksListView = objectLinksListView;

            UpdateDataFileList();
        }

        /// <summary>
        /// Updates the list of data files.
        /// </summary>
        private void UpdateDataFileList()
        {
            dataFileComboBox.Items.Clear();
            dataFileComboBox.Items.Add("All data files");
            foreach (DataFile dataFile in ObjectClassManager.DataFiles)
            {
                dataFileComboBox.Items.Add(dataFile);
            }
        }


        private void UpdateObjectListAsync()
        {
            object[] args = new object[] { searchObjectsTextbox.Text, dataFileComboBox.SelectedItem };
            if (!updateObjectListBackgroundWorker.IsBusy)
            {
                updateObjectListBackgroundWorker.RunWorkerAsync(args);
            }
            else
            {
                updateObjectListBackgroundWorker.CancelAsync();
                searchTimer.Start();
            }
        }

        /// <summary>
        /// Updates the list of objects.
        /// </summary>
        /// <param name="filter">String to search for within the object class.</param>
        /// <param name="dataFile">The datafile to search in, a null value will search in all data files.</param>
        private List<ObjectClassListViewItem> GetObjectList(string filter, object dataFile)
        {
            List<ObjectClassListViewItem> objectClassListViewItems = new List<ObjectClassListViewItem>();
            //search for items
            foreach (ObjectClass objectClass in ObjectClassManager.ObjectClasses.FindAll(
                delegate(ObjectClass objectClass)
                {
                    bool found = false;
                    if (objectClass.ToString().Contains(filter) || objectClass.DataFile.Name.Contains(filter) || objectClass.GetType().ToString().Contains(filter))
                    {
                        found = true;
                    }
                    if (dataFile == null || dataFile.GetType() != typeof(DataFile))
                    {
                        return found;
                    }
                    else
                    {
                        if (objectClass.DataFile == dataFile)
                        {
                            return found;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            ))
            {
                objectClassListViewItems.Add(new ObjectClassListViewItem(objectClass));
            }

            return objectClassListViewItems;
        }

        private void searchObjectsTextbox_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            UpdateObjectListAsync();
            searchTimer.Stop();
        }

        private void dataFileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            UpdateObjectListAsync();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProjectDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProjectDialog.ShowDialog();
        }

        private void saveProjectDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (CurrentProject != null)
            {
                CurrentProject.Save(saveProjectDialog.FileName);
            }
        }

        private void openProjectDialog_FileOk(object sender, CancelEventArgs e)
        {
            CurrentProject = Project.Load(openProjectDialog.FileName);
        }

        private void updateObjectListBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;
            e.Result = GetObjectList(args[0].ToString(), args[1]);
        }

        private void updateObjectListBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            objectClassListView.ListViewData = (List<ObjectClassListViewItem>)e.Result;
            objectClassListView.UpdateData();
        }
    }
}
