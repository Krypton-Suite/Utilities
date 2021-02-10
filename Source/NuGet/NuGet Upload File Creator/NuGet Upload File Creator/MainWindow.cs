using Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;

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
        }
    }
}
