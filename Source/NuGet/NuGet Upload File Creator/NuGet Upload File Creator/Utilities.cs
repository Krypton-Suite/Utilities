using System;
using System.Collections.Generic;
using System.IO;

namespace NuGetUploadFileCreator
{
    internal class Utilities
    {
        #region Variables
        private List<string> _directoryContent = new List<string>();

        private List<FileInfo> _files = new List<FileInfo>();
        #endregion

        #region Constructor
        public Utilities()
        {

        }
        #endregion

        #region Methods
        public static void GenerateScript(string filePath, string apiKey, string feedURL = "https://api.nuget.org/v3/index.json")
        {
            Utilities utilities = new Utilities();

            try
            {
                if (File.Exists(filePath))
                {
                    StreamWriter writer = new StreamWriter(filePath);

                    if (utilities._directoryContent.Count > 0)
                    {
                        foreach (string item in utilities._directoryContent)
                        {
                            if (item.EndsWith(".nupkg"))
                            {
                                writer.WriteLine($"dotnet nuget push { item } -k { apiKey } -s { feedURL }");
                            }
                        }

                        writer.Flush();

                        writer.Close();
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
        #endregion
    }
}