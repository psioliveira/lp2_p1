using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LP_P1
{
    class FileManager
    {
        private string path;
        internal string[] gameList;


        public FileManager(string path)
        {

            if (path.Length == 0)
            {
                path = "Games.csv";
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
