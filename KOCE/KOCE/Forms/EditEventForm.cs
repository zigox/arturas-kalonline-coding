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
    public partial class EditEventForm : Form
    {
        ProjectBuildGroupEvent Event;

        public EditEventForm(ProjectBuildGroupEvent Event)
        {
            InitializeComponent();

            this.Event = Event;

            LoadEvent();
        }

        private void LoadEvent()
        {
            programTextBox.Text = Event.Program;
            startArgsTextBox.Text = Event.CommandLineArguments;

            weightNumeric.Value = Event.Weight;

            delayNumeric.Value = Event.Delay;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            programTextBox.Text = openFileDialog1.FileName;
        }

        private void EditEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event.Program = programTextBox.Text;
            Event.CommandLineArguments = startArgsTextBox.Text;

            Event.Weight = Convert.ToInt32(weightNumeric.Value);
            Event.Delay = Convert.ToInt32(delayNumeric.Value);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Weight determines the order in which the events will be executed, a greater weight will execute later than a lesser weight.");
        }

        private void dInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Execution delay in milliseconds after the previous event.");
        }

        private void saInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check website for variable documentation.");
        }

        private void browseProgramButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
