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
    public partial class EditEditorForm : Form
    {
        public ProjectFolderEditor Editor;

        public EditEditorForm(ProjectFolderEditor Editor)
        {
            InitializeComponent();

            this.Editor = Editor;

            LoadEditor();
        }

        private void LoadEditor()
        {
            programTextBox.Text = Editor.Program;
            argsTextBox.Text = Editor.CommandLineArguments;
            extensionTextBox.Text = Editor.Filter;
        }

        private void EditEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Editor.Program = programTextBox.Text;
            Editor.CommandLineArguments = argsTextBox.Text;
            Editor.Filter = extensionTextBox.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseProgramButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = programTextBox.Text;

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            programTextBox.Text = openFileDialog1.FileName;
        }

        private void startArgsInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check website for variable documentation.");
        }

        private void extensionInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Extension with the starting dot." + Environment.NewLine + "Use '*' for all extensions.");
        }


    }
}
