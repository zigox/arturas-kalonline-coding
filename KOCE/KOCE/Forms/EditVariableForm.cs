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
    public partial class EditVariableForm : Form
    {
        public Variable Variable;

        public EditVariableForm(Variable Variable)
        {
            InitializeComponent();

            this.Variable = Variable;

            LoadVariable();
        }

        private void LoadVariable()
        {
            keyTextBox.Text = Variable.Key;
            valueTextBox.Text = Variable.Value;
        }

        private void EditVariableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variable.Key = keyTextBox.Text;
            Variable.Value = valueTextBox.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
