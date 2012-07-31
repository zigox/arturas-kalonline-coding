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
    public partial class EditVariablesForm : Form
    {
        public List<Variable> Variables;

        public EditVariablesForm(List<Variable> Variables)
        {
            InitializeComponent();

            this.Variables = Variables;

            PopulateList();
        }

        private void PopulateList()
        {
            variablesListBox.Items.Clear();

            variablesListBox.Items.AddRange(Variables.ToArray());
        }


        /// <summary>
        /// Adds a new variable.
        /// </summary>
        private void AddVariable()
        {
            Variable newVariable = new Variable("", "");

            Variables.Add(newVariable);

            variablesListBox.Items.Add(newVariable);

            variablesListBox.SelectedItem = newVariable;

            EditVariable();
        }

        /// <summary>
        /// Edits the currently selected variable.
        /// </summary>
        private void EditVariable()
        {
            if (variablesListBox.SelectedItem != null)
            {
                Variable selectedVariable = variablesListBox.SelectedItem as Variable;

                EditVariableForm evf = new EditVariableForm(selectedVariable);

                evf.ShowDialog();

                PopulateList();
            }
        }

        /// <summary>
        /// Removes the currently selected variable.
        /// </summary>
        private void RemoveVariable()
        {
            if (variablesListBox.SelectedItem != null)
            {
                Variable selectedVariable = variablesListBox.SelectedItem as Variable;

                DialogResult result = MessageBox.Show("Are you sure you wish to remove this variable?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    variablesListBox.Items.Remove(selectedVariable);
                    Variables.Remove(selectedVariable);
                }
            }
        }

        private void addVariableButton_Click(object sender, EventArgs e)
        {
            AddVariable();
        }

        private void removeVariableButton_Click(object sender, EventArgs e)
        {
            RemoveVariable();
        }

        private void editVariableButton_Click(object sender, EventArgs e)
        {
            EditVariable();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void variablesListBox_DoubleClick(object sender, EventArgs e)
        {
            EditVariable();
        }
    }
}
