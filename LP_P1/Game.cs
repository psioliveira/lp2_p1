using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP_P1
{
    class Game
    {
        private int ID;
        private string name;
        private DateTime releaseDate;
        private int requiredAge;
        private int dlcCount;
        private int metacritic;
        private int movieCount;
        private int recomendationCount;
        private int screenshotCount;
        private int owners;
        private int numberOfPlayers;
        private int achievementCount;
        private bool controllSupport;
        private bool plataformWindows;
        private bool plataformLinux;
        private bool plataformMac;
        private bool categorySinglePlayer;
        private bool categoryMultiplayer;
        private bool categoryCoop;
        private bool categoryIncludeLevelEditor;
        private bool categoryVRSupport;
        private Uri supportURL;
        private string aboutText;
        private Uri headerImage;
        private Uri website;

        public Game(string str)
        {
            string[] data = str.Split(','); //splitted string

            ID = Convert.ToInt32(data[0]);
            name = data[1];
            releaseDate = Convert.ToDateTime(data[2]);
            requiredAge = Convert.ToInt32(data[3]);
            dlcCount = Convert.ToInt32(data[4]);
            metacritic = Convert.ToInt32(data[5]);
            movieCount = Convert.ToInt32(data[6]);
            recomendationCount = Convert.ToInt32(data[7]);
            screenshotCount = Convert.ToInt32(data[8]);
            owners = Convert.ToInt32(data[9]);
            numberOfPlayers = Convert.ToInt32(data[10]);
            achievementCount = Convert.ToInt32(data[11]);
            controllSupport = Convert.ToBoolean(data[12]);
            plataformWindows = Convert.ToBoolean(data[13]);
            plataformLinux = Convert.ToBoolean(data[14]);
            plataformMac = Convert.ToBoolean(data[15]);
            categorySinglePlayer = Convert.ToBoolean(data[16]);
            categoryMultiplayer = Convert.ToBoolean(data[17]);
            categoryCoop = Convert.ToBoolean(data[18]);
            categoryIncludeLevelEditor = Convert.ToBoolean(data[19]);
            categoryVRSupport = Convert.ToBoolean(data[20]);
            supportURL = ChooseUrl(data[21]);
            aboutText = data[22];
            headerImage = ChooseUrl(data[23]);
            website = ChooseUrl(data[24]);
        }

        public void PrintAllValues()
        {
            Console.WriteLine(ID);
            Console.WriteLine(name);
            Console.WriteLine(releaseDate.ToString());
            Console.WriteLine(requiredAge);
            Console.WriteLine(dlcCount);
            Console.WriteLine(metacritic);
            Console.WriteLine(movieCount);
            Console.WriteLine(recomendationCount);
            Console.WriteLine(screenshotCount);
            Console.WriteLine(owners);
            Console.WriteLine(numberOfPlayers);
            Console.WriteLine(achievementCount);
            Console.WriteLine(controllSupport);
            Console.WriteLine(plataformWindows);
            Console.WriteLine(plataformLinux);
            Console.WriteLine(plataformMac);
            Console.WriteLine(categorySinglePlayer);
            Console.WriteLine(categoryMultiplayer);
            Console.WriteLine(categoryCoop);
            Console.WriteLine(categoryIncludeLevelEditor);
            Console.WriteLine(categoryVRSupport);
            Console.WriteLine(printUrl(supportURL));
            Console.WriteLine(aboutText);
            Console.WriteLine(printUrl(headerImage));
            Console.WriteLine(printUrl(website));


        }

        public Uri ChooseUrl(string str)
        {
            if (str == "None" || str == "none")
            {
                Uri urlbase = null;
                return urlbase;
            }
            else
            {
                Uri urlbase = new Uri(str);
                return urlbase;
            }


        }


        public string printUrl(Uri url)
        {
            string s;
            if (url == null)
            {
                s = "None.";
            }
            else
            {
                s = website.ToString();
            }

            return s;
        }





    }
}

