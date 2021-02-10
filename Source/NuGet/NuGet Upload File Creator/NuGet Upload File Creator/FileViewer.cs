using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;

namespace NuGetUploadFileCreator
{
    public partial class FileViewer : KryptonForm
    {
        #region Variables
        private List<string> _directoryContent = new List<string>();
        #endregion

        public FileViewer(string directoryPath)
        {
            InitializeComponent();

            PropagateFileList(directoryPath);
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #region Methods
        private void GetDirectoryContents(string directoryPath)
        {
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                _directoryContent.Add(file);
            }
        }

        private void PropagateFileList(string directoryPath)
        {
            GetDirectoryContents(directoryPath);

            foreach (string item in _directoryContent)
            {
                klbFiles.Items.Add(item);
            }
        }
        #endregion
    }
}
