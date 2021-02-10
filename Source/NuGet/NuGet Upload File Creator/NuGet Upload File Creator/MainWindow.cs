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
            }
        }

        private void ktxtScriptName_TextChanged(object sender, EventArgs e)
        {
            if (ktxtScriptName.Text != string.Empty)
            {
                kbtnGenerateScript.Enabled = true;
            }
            else
            {
                kbtnGenerateScript.Enabled = false;
            }
        }
    }
}
