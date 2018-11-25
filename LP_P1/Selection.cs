using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_P1
{
    internal class Selection
    {
        internal Renderer rend = new Renderer();
        internal List<Game> gameList;
        public Selection(List<Game> gameList, Renderer rend)
        {
            this.gameList = gameList;
            this.rend = rend;
        }

        public void StartFiltering()
        {
            rend.Menu();
            //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}", 
            //    rend.values[0], rend.values[1],rend.values[2], rend.values[3], rend.values[4],
            //     rend.values[5], rend.values[6], rend.values[7], rend.values[8], rend.values[9],
            //      rend.values[10], rend.values[11], rend.values[12], rend.values[13], rend.values[14], rend.values[15]);
            
            FilterSearch(rend.values);
        }

        private void FilterSearch(string[] s)
        {
            DateTime d = default(DateTime);

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.name.Contains(s[i])).ToList());
                }

                if (i == 1 && s[i] != " ")
                {
                    DateTime.TryParse(s[i], out d);
                    gameList = (gameList.Where(game => game.releaseDate >= d).ToList());
                }
                if (i == 2 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.requiredAge >= Convert.ToInt32(s[i])).ToList());
                }

                if (i == 3 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.metacritic >= Convert.ToInt32(s[i])).ToList());
                }

                if (i == 4 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.recommendationCount == Convert.ToInt32(s[i])).ToList());
                }

                if (i == 5 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.controllSupport == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 6 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.platformWindows == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 7 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.platformLinux == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 8 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.platformMac == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 9 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.categorySinglePlayer == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 10 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.categoryMultiplayer == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 11 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.categoryCoop == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 12 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.categoryIncludeLevelEditor == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 13 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.categoryVRSupport == Convert.ToBoolean(s[i])).ToList());
                }

                if (i == 15 && s[i] != " ")
                {
                    gameList = (gameList.Where(game => game.id == Convert.ToInt32(s[i])).ToList());
                }
            }
            if (s[14] != " ") { SortList(s[14]); }
        }

        public void SortList(string s)
        {
            if (s == "ID")
            {
                gameList = gameList.OrderBy(game => game.id).ToList();
            }

            if (s == "NAME")
            {
                gameList = gameList.OrderBy(game => game.name).ToList();
            }

            if (s == "LAUNCH DATE")
            {
                gameList = gameList.OrderBy(game => game.releaseDate).ToList();
            }
        }

        public void PrintFiltered()
        {
            foreach (Game g in gameList)
            {
                g.PrintAllValues();
            }
        }


    }
}
