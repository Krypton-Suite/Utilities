using Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NuGetUploadFileCreator
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private string _scriptFilePath;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.IsFolderPicker = true;

            cofd.Title = "Browse to package directory:";

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtPackagePath.Text = Path.GetFullPath(cofd.FileName);
            }

            kbtnViewContents.Enabled = true;
        }

        private void kbtnViewContents_Click(object sender, EventArgs e)
        {
            FileViewer viewer = new FileViewer(ktxtPackagePath.Text);

            viewer.Show();
        }

        private void kbtnOpenInExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(ktxtPackagePath.Text);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ktxtPackagePath_TextChanged(object sender, EventArgs e)
        {
            if (ktxtPackagePath.Text != string.Empty)
            {
                kbtnOpenInExplorer.Enabled = true;
            }
        }

        private void kbtnGenerateScript_Click(object sender, EventArgs e)
        {
            if (ktxtAPIKey.Text == string.Empty)
            {
                DialogResult result = KryptonMessageBox.Show("No API key has been provided, to upload NuGet packages you'll need a API key.\nDo you want to set one now?", "Generate Script", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                {
                    Utilities.GenerateScript(_scriptFilePath, "<##API-KEY##>");
                }
                else
                {
                    Utilities.GenerateScript(_scriptFilePath, ktxtAPIKey.Text);
                }
            }
        }

        private void ktxtScriptName_TextChanged(object sender, EventArgs e)
        {
            if (ktxtScriptName.Text != string.Empty)
            {
                kbtnCreateFile.Enabled = true;
            }
            else
            {
                kbtnCreateFile.Enabled = false;
            }
        }

        private void kbtnCreateFile_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog csfd = new CommonSaveFileDialog();

            csfd.Title = "Save script file:";

            csfd.Filters.Add(new CommonFileDialogFilter("Batch Files", "bat, cmd, nt"));

            csfd.DefaultFileName = ktxtScriptName.Text;

            if (csfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                _scriptFilePath = Path.GetFullPath(csfd.FileName);

                File.Create(Path.GetFullPath(csfd.FileName));

                kbtnGenerateScript.Enabled = true;

                kbtnCreateFile.Enabled = false;
            }
        }
    }
}
