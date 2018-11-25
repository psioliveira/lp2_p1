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
            FilterSearch(rend.values);
        }

        public void FilterSearch(string[] s)
        {
            bool[] selections = new bool[16];
            DateTime d = default(DateTime);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != " ")
                {
                    if (i == 0)
                        gameList = (gameList.Where(game => game.name.Contains(s[i])).ToList());
                    if (i == 1)
                    {
                        DateTime.TryParse(s[i], out d);
                        gameList = (gameList.Where(game => game.releaseDate >= d).ToList());
                    }
                    if (i == 2)
                        gameList = (gameList.Where(game => game.requiredAge >= Convert.ToInt32(s[i])).ToList());
                    if (i == 3)
                        gameList = (gameList.Where(game => game.metacritic >= Convert.ToInt32(s[i])).ToList());
                    if (i == 4)
                        gameList = (gameList.Where(game => game.recommendationCount == Convert.ToInt32(s[i])).ToList());
                    if (i == 5)
                        gameList = (gameList.Where(game => game.controllSupport == Convert.ToBoolean(s[i])).ToList());
                    if (i == 6)
                        gameList = (gameList.Where(game => game.platformWindows == Convert.ToBoolean(s[i])).ToList());
                    if (i == 7)
                        gameList = (gameList.Where(game => game.platformLinux == Convert.ToBoolean(s[i])).ToList());
                    if (i == 8)
                        gameList = (gameList.Where(game => game.platformMac == Convert.ToBoolean(s[i])).ToList());
                    if (i == 9)
                        gameList = (gameList.Where(game => game.categorySinglePlayer == Convert.ToBoolean(s[i])).ToList());
                    if (i == 10)
                        gameList = (gameList.Where(game => game.categoryMultiplayer == Convert.ToBoolean(s[i])).ToList());
                    if (i == 11)
                        gameList = (gameList.Where(game => game.categoryCoop == Convert.ToBoolean(s[i])).ToList());
                    if (i == 12)
                        gameList = (gameList.Where(game => game.categoryIncludeLevelEditor == Convert.ToBoolean(s[i])).ToList());
                    if (i == 13)
                        gameList = (gameList.Where(game => game.categoryVRSupport == Convert.ToBoolean(s[i])).ToList());
                }
            }
        }

        public void SortList(string s)
        {
            if(s == "ID")
            {
                gameList = gameList.OrderBy(game => game.id).ToList();
            }
        }

       public void PrintFiltered()
        {
        }


    }
}
