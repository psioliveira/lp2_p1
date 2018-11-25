using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP_P1
{
    class Game
    {

        internal readonly int id;
        internal readonly string name;
        internal readonly DateTime releaseDate;
        internal readonly int requiredAge;
        internal readonly int dlcCount;
        internal readonly int metacritic;






        internal readonly int movieCount;
        internal readonly int recommendationCount;
        internal readonly int screenshotCount;
        internal readonly int owners;
        internal readonly int numberOfPlayers;
        internal readonly int achievementCount;
        internal readonly bool controllSupport;
        internal readonly bool platformWindows;
        internal readonly bool platformLinux;
        internal readonly bool platformMac;
        internal readonly bool categorySinglePlayer;
        internal readonly bool categoryMultiplayer;
        internal readonly bool categoryCoop;
        internal readonly bool categoryIncludeLevelEditor;
        internal readonly bool categoryVRSupport;
        internal readonly Uri supportURL;
        internal readonly string aboutText;
        internal readonly Uri headerImage;
        internal readonly Uri website;

        public Game(string[] s)
        {
            id = Convert.ToInt32(s[0]);
            name = s[1];
            releaseDate =ChooseDateTime(s[2]);
            requiredAge = Convert.ToInt32(s[3]);
            dlcCount = Convert.ToInt32(s[4]);
            metacritic = Convert.ToInt32(s[5]);
            movieCount = Convert.ToInt32(s[6]);
            recommendationCount = Convert.ToInt32(s[7]);
            screenshotCount = Convert.ToInt32(s[8]);
            owners = Convert.ToInt32(s[9]);
            numberOfPlayers = Convert.ToInt32(s[10]);
            achievementCount = Convert.ToInt32(s[11]);
            controllSupport = Convert.ToBoolean(s[12]);
            platformWindows = Convert.ToBoolean(s[13]);
            platformLinux = Convert.ToBoolean(s[14]);
            platformMac = Convert.ToBoolean(s[15]);
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
            Console.WriteLine("name: " + releaseDate);
            Console.WriteLine("release date: " + releaseDate.ToString());
            Console.WriteLine("minimum age:" + requiredAge);
            Console.WriteLine("DLCs:" + dlcCount);
            Console.WriteLine("metacritic: " + metacritic);
            Console.WriteLine("movies: " + movieCount);
            Console.WriteLine("recommendation: " + recommendationCount);
            Console.WriteLine("screenshots :" + screenshotCount);
            Console.WriteLine("purchases: " + owners);
            Console.WriteLine("players: " + numberOfPlayers);
            Console.WriteLine("achievements: " + achievementCount);
            Console.WriteLine("have controls: " + controllSupport);
            Console.WriteLine("for windows: " + platformWindows);
            Console.WriteLine("for linux: " + platformLinux);
            Console.WriteLine("for macOS: " + platformMac);
            Console.WriteLine("single player: " + categorySinglePlayer);
            Console.WriteLine("multiplayer: " + categoryMultiplayer);
            Console.WriteLine("coop: " + categoryCoop);
            Console.WriteLine("level editor: " + categoryIncludeLevelEditor);
            Console.WriteLine("vr supported: " + categoryVRSupport);
            Console.WriteLine("site: " + PrintUrl(supportURL));
            Console.WriteLine("about: " + aboutText);
            Console.WriteLine("image url: " + PrintUrl(headerImage));
            Console.WriteLine("prints url: " + PrintUrl(website));
            
        }

        public Uri ChooseUrl(string str)
        {
            Uri urlbase;
            if (str == "None" || str == "none" || str ==" ")
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


        public DateTime ChooseDateTime(string str)
        {
            DateTime DateTimeBase;
            if (str == "None" || str == "none" || str == " ")
            {
                DateTimeBase = default(DateTime);
                return DateTimeBase;
            }
            else
            {

                bool isDateTime = DateTime.TryParse(str, out DateTimeBase);
                if (isDateTime == false)
                {
                    DateTimeBase = default(DateTime);
                }
                return DateTimeBase;
            }

        }

    }
}

