using Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;

namespace NuGetUploadFileCreator
{
    public partial class ScriptViewer : KryptonForm
    {
        #region Variables
        private string _scriptFilePath;
        #endregion

        #region Constructors
        public ScriptViewer()
        {
            InitializeComponent();
        }

        public ScriptViewer(string scriptFilePath)
        {
            InitializeComponent();

            _scriptFilePath = scriptFilePath;

            try
            {
                krtbEditFile.LoadFile(_scriptFilePath);
            }
            catch (Exception e)
            {

                throw;
            }
        }
        #endregion

        private void kbtnOpen_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Browse for a script file:";

            cofd.Filters.Add(new CommonFileDialogFilter("Batch Files", "bat, cmd, nt"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                krtbEditFile.LoadFile(Path.GetFullPath(cofd.FileName));
            }
        }
    }
}
