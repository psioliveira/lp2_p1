using System;
using System.IO;

namespace LP_P1
{
    class FileManager
    {
        private readonly string path;
        internal string[] gameList;


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

        public string[] SplitLine(string str)
        {
            string[] data = str.Split(','); //splitted string
            return data;
        }

    }
}
