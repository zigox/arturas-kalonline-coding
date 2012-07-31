using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kml;
using System.Deployment.Application;
using System.IO;
using DDay.Update;
using QWhale.Editor.Dialogs;

namespace KmlEditor
{
    public partial class MainForm : Form
    {

        private const string BLANK_NAME = "New File";
        private const string PROGRAM_NAME = "KML Editor";

        private CharPosition ErrorPosition = new CharPosition(-1,-1,-1);

        string CurrentFile = "";
        bool Saved = true;
        bool SyntaxValid = false;

        public MainForm()
        {
            InitializeComponent();

            UpdateBootstrap();

            UpdateName();

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                OpenFile(args[1]);
            }


        }

        private void UpdateBootstrap()
        {
            try
            {
                UpdateManager.UpdateBootstrapFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating bootstrap: " + ex.Message);
            }
        }

        /// <summary>
        /// Saves the current file.
        /// </summary>
        private void Save()
        {
            //check if its a new file
            if (CurrentFile == "")
            {
                //file is new so we need to save as
                SaveAs();
            }
            else
            {
                //save the file
                syntaxEdit.SaveFile(CurrentFile);
                Saved = true;
            }

            UpdateName();
        }

        /// <summary>
        /// Shows a save-as dialog.
        /// </summary>
        private void SaveAs()
        {
            //shows a dialog
            DialogResult result = saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Saves the file under a new file name.
        /// </summary>
        /// <param name="FileName"></param>
        private void SaveAs(string FileName)
        {
            //set new current file
            this.CurrentFile = FileName;
            this.Save();
        }

        private string ShortFileName
        {
            get
            {
                if (File.Exists(CurrentFile))
                {
                    FileInfo fi = new FileInfo(CurrentFile);
                    return fi.Name;
                }
                else
                {
                    return "New File";
                }
            }
        }

        /// <summary>
        /// Checks if the file needs to be saved and shows a confirmation.
        /// </summary>
        private bool ConfirmCloseFile
        {
            get
            {
                if (!Saved)
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("The file " + ShortFileName + " has not been saved, would you like to save before you close it?", "Confirm", MessageBoxButtons.YesNoCancel);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            Save();
                            return ConfirmCloseFile;
                        case DialogResult.No:
                            return true;
                        case DialogResult.Cancel:
                            return false;
                        default:
                            return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Closes the current file.
        /// </summary>
        private void CloseFile()
        {
            this.CurrentFile = "";
            this.Saved = true;
            syntaxEdit.Text = "";
            
            //update form name
            UpdateName();
        }

        /// <summary>
        /// Updates the forms name.
        /// </summary>
        private void UpdateName()
        {
            if (this.Saved)
            {
                this.Text = ShortFileName + " - " + PROGRAM_NAME;
            }
            else
            {
                this.Text = ShortFileName + "* - " + PROGRAM_NAME;
            }
        }

        /// <summary>
        /// Shows the open file dialog.
        /// </summary>
        /// <param name="FileName"></param>
        private void OpenFile()
        {
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// Opens a file.
        /// </summary>
        /// <param name="FileName"></param>
        private void OpenFile(string FileName)
        {
            //check if a file needs to be saved
            if (ConfirmCloseFile)
            {
                //close the current file
                CloseFile();

                //open the file
                syntaxEdit.LoadFile(FileName);

                //set our new file name and saved state
                this.CurrentFile = FileName;
                this.Saved = true;
            }
            ValidateSyntax();
            UpdateName();
        }

        private void NewFile()
        {
            if (ConfirmCloseFile)
            {
                CloseFile();
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void syntaxEdit_TextChanged(object sender, EventArgs e)
        {
            //text has been changed so set saved to false
            Saved = false;
            //update name
            UpdateName();
            //validate syntax
            ValidateSyntax();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                //save file asap then shutdown
                e.Cancel = false;
            }
            else
            {
                e.Cancel = !ConfirmCloseFile;
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFile(openFileDialog.FileName);
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveAs(saveFileDialog.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Syntax validation

        private void ValidateSyntax()
        {
            if (!syntaxValidator.IsBusy)
            {
                SetSyntaxValidating();
                syntaxValidator.RunWorkerAsync(syntaxEdit.Text);
            }
            
        }

        private void syntaxValidator_DoWork(object sender, DoWorkEventArgs e)
        {
            string source = e.Argument as string;
            string error = "";
            bool valid = true;
            CharPosition position = new CharPosition(-1, -1, -1);

            try
            {
                KmlDocument kdoc = new KmlDocument();
                kdoc.LoadFromString(source);

            }
            catch (Exception ex)
            {
                error = ex.InnerException.Message;
                position = ex.InnerException.Data["Position"] as CharPosition;
                valid = false;
            }

            e.Result = new SyntaxValidationResult(valid,error,position);
            

        }

        private void syntaxValidator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SyntaxValidationResult result = e.Result as SyntaxValidationResult;

            RemoveErrorLineStyle();

            if (result.Valid)
            {
                SetSyntaxValidated();
            }
            else
            {
                SetSyntaxError(result.Error, result.ErrorPosition);
            }
        }

        private void RemoveErrorLineStyle()
        {
            syntaxEdit.Source.LineStyles.RemoveLineStyle(ErrorPosition.Row - 1);
        }

        private void HighlightLine(int Line)
        {
            syntaxEdit.Source.LineStyles.SetLineStyle(Line, 0);
        }

        private void SetSyntaxError(string Error, CharPosition Position)
        {
            validationStatusLabel.Text = "Syntax Error: " + Error;
            validationStatusLabel.ForeColor = Color.White;
            validationStatusLabel.BackColor = Color.Red;

            
            HighlightLine(ErrorPosition.Row -1);

            ErrorPosition = Position;
        }

        private void SetSyntaxValidated()
        {
            validationStatusLabel.Text = "Syntax Validated at " + DateTime.Now;
            validationStatusLabel.ForeColor = Color.White;
            validationStatusLabel.BackColor = Color.Green;

            ErrorPosition = new CharPosition(-1, -1, -1);
        }

        private void SetSyntaxValidating()
        {
            validationStatusLabel.Text = "Syntax Validating...";
            validationStatusLabel.ForeColor = Color.Black;
            validationStatusLabel.BackColor = Color.Yellow;

            ErrorPosition = new CharPosition(-1, -1, -1);
        }

        //toolstrip

        private void validateToolStripButton_Click(object sender, EventArgs e)
        {
            ValidateSyntax();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        //edit menu

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syntaxEdit.Source.CanUndo())
            {
                syntaxEdit.Source.Undo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syntaxEdit.Selection.CanCut())
            {
                syntaxEdit.Selection.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syntaxEdit.Selection.CanCopy())
            {
                syntaxEdit.Selection.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syntaxEdit.Selection.CanPaste())
            {
                syntaxEdit.Selection.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.Selection.Delete();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.DisplaySearchDialog();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.FindNext();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.DisplayReplaceDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.DisplayGotoLineDialog();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.Selection.SelectAll();
        }

        private void insertDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syntaxEdit.Selection.InsertString(DateTime.Now.ToString());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aForm = new AboutForm();
            aForm.ShowDialog();
        }

        private void FormatSyntax()
        {
            KmlDocument kdoc = new KmlDocument();

            ValidateSyntax();

            try
            {
                kdoc.LoadFromString(syntaxEdit.Text);

                this.syntaxEdit.Text = kdoc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Syntax must be valid before formatting.");
            }
        }

        private void formatSyntaxToolStripButton_Click(object sender, EventArgs e)
        {
            FormatSyntax();
        }

        private void SelectErrorLocation()
        {
            if (!SyntaxValid)
            {
                syntaxEdit.Selection.SelectionStart = ErrorPosition.Offset;
            }
        }

        private void validationStatusLabel_Click(object sender, EventArgs e)
        {
            SelectErrorLocation();
        }
    }
}
