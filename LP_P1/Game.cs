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

        public Game(string[] s)
        {
            ID = Convert.ToInt32(s[0]);
            name = s[1];
            releaseDate = Convert.ToDateTime(s[2]);
            requiredAge = Convert.ToInt32(s[3]);
            dlcCount = Convert.ToInt32(s[4]);
            metacritic = Convert.ToInt32(s[5]);
            movieCount = Convert.ToInt32(s[6]);
            recomendationCount = Convert.ToInt32(s[7]);
            screenshotCount = Convert.ToInt32(s[8]);
            owners = Convert.ToInt32(s[9]);
            numberOfPlayers = Convert.ToInt32(s[10]);
            achievementCount = Convert.ToInt32(s[11]);
            controllSupport = Convert.ToBoolean(s[12]);
            plataformWindows = Convert.ToBoolean(s[13]);
            plataformLinux = Convert.ToBoolean(s[14]);
            plataformMac = Convert.ToBoolean(s[15]);
            categorySinglePlayer = Convert.ToBoolean(s[16]);
            categoryMultiplayer = Convert.ToBoolean(s[17]);
            categoryCoop = Convert.ToBoolean(s[18]);
            categoryIncludeLevelEditor = Convert.ToBoolean(s[19]);
            categoryVRSupport = Convert.ToBoolean(s[20]);
            supportURL = ChooseUrl(s[21]);
            aboutText = s[22];
            headerImage = ChooseUrl(s[23]);
            website = ChooseUrl(s[24]);

        }

        public void PrintAllValues()
        {
            Console.WriteLine("id: " + ID);
            Console.WriteLine("name: " + name);
            Console.WriteLine("release date: " + releaseDate.ToString());
            Console.WriteLine("minimum age:" + requiredAge);
            Console.WriteLine("DLCs:" + dlcCount);
            Console.WriteLine("metacritic: " + metacritic);
            Console.WriteLine("movies: " + movieCount);
            Console.WriteLine("recomendation: " + recomendationCount);
            Console.WriteLine("screenshots :" + screenshotCount);
            Console.WriteLine("purchases: " + owners);
            Console.WriteLine("players: " + numberOfPlayers);
            Console.WriteLine("achievements: " + achievementCount);
            Console.WriteLine("have controls: " + controllSupport);
            Console.WriteLine("windows?: " + plataformWindows);
            Console.WriteLine("linux?: " + plataformLinux);
            Console.WriteLine("macOS?: " + plataformMac);
            Console.WriteLine("sigle player?: " + categorySinglePlayer);
            Console.WriteLine("multiplayer?: " + categoryMultiplayer);
            Console.WriteLine("coop?: " + categoryCoop);
            Console.WriteLine("level editor?: " + categoryIncludeLevelEditor);
            Console.WriteLine("vr support?: " + categoryVRSupport);
            Console.WriteLine("site: " + PrintUrl(supportURL));
            Console.WriteLine("about: " + aboutText);
            Console.WriteLine("image url: " + PrintUrl(headerImage));
            Console.WriteLine("prints url: " + PrintUrl(website));
            
        }

        public Uri ChooseUrl(string str)
        {
            Uri urlbase;
            if (str == "None" || str == "none")
            {
                urlbase = null;
                return urlbase;
            }
            else
            {

                bool isUrl = Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out urlbase);
                if (isUrl == false)
                {
                    urlbase = null;
                }
                return urlbase;
            }

        }


        public string PrintUrl(Uri url)
        {
            string s;
            if (url == null)
            {
                s = "None.";
            }
            else
            {
                s = url.ToString();
            }

            return s;
        }

        public int GetId()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.name;
        }



    }
}

