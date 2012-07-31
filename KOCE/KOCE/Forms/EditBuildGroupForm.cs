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
    public partial class EditBuildGroupForm : Form
    {
        public ProjectBuildGroup BuildGroup;

        public EditBuildGroupForm(ProjectBuildGroup BuildGroup)
        {
            InitializeComponent();

            this.BuildGroup = BuildGroup;

            LoadBuildGroup();
        }

        private void LoadBuildGroup()
        {
            //set name textbox
            nameTextBox.Text = BuildGroup.Name;

            PopulateEventList();
        }

        private void PopulateEventList()
        {
            //clear all items
            eventsListBox.Items.Clear();
            //order the events
            BuildGroup.Events = BuildGroup.Events.OrderBy(x => x.Weight).ToList();
            //add all events
            eventsListBox.Items.AddRange(BuildGroup.Events.ToArray());
        }

        private void AddEvent()
        {
            //create new builgroud
            ProjectBuildGroupEvent newEvent = new ProjectBuildGroupEvent("","",0,0);

            //add to project
            BuildGroup.Events.Add(newEvent);

            //add to list
            eventsListBox.Items.Add(newEvent);

            //select in list
            eventsListBox.SelectedItem = newEvent;

            //edit the newly created BG
            EditEvent();
        }

        private void RemoveEvent()
        {
            //check if item is selected
            if (eventsListBox.SelectedItem != null)
            {
                //make confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to remove this event?", "Confirmation", MessageBoxButtons.YesNo);

                //check if its a yes
                if (result == DialogResult.Yes)
                {
                    //get currently selected event
                    ProjectBuildGroupEvent selectedEvent = eventsListBox.SelectedItem as ProjectBuildGroupEvent;

                    //remove it from list
                    eventsListBox.Items.Remove(selectedEvent);

                    //remove it from project
                    BuildGroup.Events.Remove(selectedEvent);
                }
            }
        }

        private void EditEvent()
        {
            //check if build group is selected
            if (eventsListBox.SelectedItem != null)
            {
                //get selected build group
                ProjectBuildGroupEvent selectedEvent = eventsListBox.SelectedItem as ProjectBuildGroupEvent;

                EditEventForm eef = new EditEventForm(selectedEvent);

                eef.ShowDialog();

                PopulateEventList();
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void removeEventButton_Click(object sender, EventArgs e)
        {
            RemoveEvent();
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            EditEvent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBuildGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save name
            BuildGroup.Name = nameTextBox.Text;
        }

        private void eventsListBox_DoubleClick(object sender, EventArgs e)
        {
            EditEvent();
        }
    }
}
