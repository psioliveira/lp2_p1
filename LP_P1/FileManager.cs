using System;
using System.IO;

namespace LP_P1
{
    class FileManager
    {
    /// <summary>
    /// Class used for manage the csv file
    /// </summary>
        private readonly string path;
        internal string[] gameList;

        /// <summary>
        /// method to validate the csv file
        /// </summary>
        /// <param name="path">Comand line argument passed by the user.</param>
        public FileManager(string path)
        {

            if (path.Length == 0)
            {
                Console.WriteLine("path not found.");
                System.Environment.Exit(1);
            }
            else { this.path = path; }

            gameList = TryOppen(path);
        }

        /// <summary>
        /// method who tries to open the file.
        /// </summary>
        /// <param name="path"> file path </param>
        /// <returns></returns>
        private string[] TryOppen(string path)
        {
            try
            {
                return File.ReadAllLines(path);
                 
            }
            catch
            {
                throw new Exception("File not found or FileType Could not be oppened");
                
            }
        }
         /// <summary>
         /// method to split the file lines by comas.
         /// </summary>
         /// <param name="str"> file string </param>
         /// <returns></returns>
        internal string[] SplitLine(string str)
        {
            string[] data = str.Split(','); //splitted string
            return data;
        }

    }
}
