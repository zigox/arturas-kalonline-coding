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
    public partial class EditBuildGroupsForm : Form
    {
        List<ProjectBuildGroup> BuildGroups;

        public EditBuildGroupsForm(List<ProjectBuildGroup> BuildGroups)
        {
            InitializeComponent();

            this.BuildGroups = BuildGroups;

            PopulateBuildGroupsList();
        }

        private void PopulateBuildGroupsList()
        {
            buildGroupListBox.Items.Clear();

            buildGroupListBox.Items.AddRange(BuildGroups.ToArray());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBuildGroup()
        {
            //create new builgroud
            ProjectBuildGroup newBG = new ProjectBuildGroup("");

            //add to project
            BuildGroups.Add(newBG);

            //add to list
            buildGroupListBox.Items.Add(newBG);

            //select in list
            buildGroupListBox.SelectedItem = newBG;

            //edit the newly created BG
            EditBuildGroup();
        }

        private void RemoveBuildGroup()
        {
            //check if item is selected
            if (buildGroupListBox.SelectedItem != null)
            {
                //make confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to remove this Build Group?", "Confirmation", MessageBoxButtons.YesNo);

                //check if its a yes
                if (result == DialogResult.Yes)
                {
                    //get currently selected BG
                    ProjectBuildGroup selectedBG = buildGroupListBox.SelectedItem as ProjectBuildGroup;

                    //remove it from list
                    buildGroupListBox.Items.Remove(selectedBG);

                    //remove it from project
                    BuildGroups.Remove(selectedBG);
                }
            }
        }

        private void EditBuildGroup()
        {
            //check if build group is selected
            if (buildGroupListBox.SelectedItem != null)
            {
                //get selected build group
                ProjectBuildGroup selectedBG = buildGroupListBox.SelectedItem as ProjectBuildGroup;

                EditBuildGroupForm ebgf = new EditBuildGroupForm(selectedBG);

                ebgf.ShowDialog();

                PopulateBuildGroupsList();
            }
        }

        private void addBuildGroupButton_Click(object sender, EventArgs e)
        {
            AddBuildGroup();
        }

        private void removeBuildGroupButton_Click(object sender, EventArgs e)
        {
            RemoveBuildGroup();
        }

        private void editBuildGroupButton_Click(object sender, EventArgs e)
        {
            EditBuildGroup();
        }

        private void buildGroupListBox_DoubleClick(object sender, EventArgs e)
        {
            EditBuildGroup();
        }
    }
}
