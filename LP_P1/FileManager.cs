using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

            gameList = File.ReadAllLines(path);
        }
        

        public string[] SplitLine(string str)
        {
            string[] data = str.Split(','); //splitted string
            return data;
        }

    }
}
