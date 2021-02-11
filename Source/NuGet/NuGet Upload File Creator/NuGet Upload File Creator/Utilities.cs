using Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NuGetUploadFileCreator
{
    internal class Utilities
    {
        #region Variables
        private string[] _fileList;

        private List<string> _directoryContent = new List<string>(), _fileNames = new List<string>();

        private List<FileInfo> _files = new List<FileInfo>();
        #endregion

        #region Constructor
        public Utilities()
        {

        }
        #endregion

        #region Setters & Getters
        public void SetFileList(string directoryPath) => _fileList = Directory.GetFiles(directoryPath, "*.nupkg");

        public string[] GetFileList() => _fileList;
        #endregion

        #region Methods
        /// <summary>Propagates the file list.</summary>
        /// <param name="directoryPath">The directory path.</param>
        public static void PropagateFileList(string directoryPath)
        {
            Utilities utilities = new Utilities();

            try
            {
                utilities.SetFileList(directoryPath);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        /// <summary>Propagates the file list.</summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="listBox">The list box.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static List<string> PropagateFileList(string directoryPath, KryptonListBox listBox)
        {
            Utilities utilities = new Utilities();

            try
            {
                if (utilities.GetFileList().Length <= 0)
                {
                    PropagateFileList(directoryPath);
                }

                foreach (string file in utilities.GetFileList())
                {
                    listBox.Items.Add(file);

                    utilities._fileNames.Add(file);
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return utilities._fileNames;
        }

        public static void GenerateScript(string filePath, string apiKey, string feedURL = "https://api.nuget.org/v3/index.json", bool skipDuplicate = false)
        {
            Utilities utilities = new Utilities();

            try
            {
                //string scriptFilePath;
                if (File.Exists(filePath))
                { 
                    StreamWriter writer = new StreamWriter(filePath);

                    if (utilities._directoryContent.Count > 0)
                    {
                        foreach (string item in utilities._directoryContent)
                        {
                            if (item.EndsWith(".nupkg"))
                            {
                                if (skipDuplicate)
                                {
                                    writer.WriteLine($"dotnet nuget push { item } -k { apiKey } -s { feedURL } --skip-duplicate");
                                }
                                else
                                {
                                    writer.WriteLine($"dotnet nuget push { item } -k { apiKey } -s { feedURL }");
                                }
                            }
                        }

                        writer.WriteLine("pause");

                        writer.Flush();

                        writer.Close();
                    }

                    DialogResult result = KryptonMessageBox.Show($"The file: { Path.GetFileName(filePath) } has been created.\nDo you want to view this file now?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                KryptonMessageBox.Show($"An error has occurred: { e.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}