using System;
using System.Collections.Generic;
using System.Linq;

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

        internal void StartFiltering()
        {
            rend.Menu();

            FilterSearch(rend.values);
        }

        private void FilterSearch(string[] s)
        {
            DateTime d = default(DateTime);

            for (int i = 0; i < s.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.name.Contains(s[i])).ToList();
                        }
                        break;
                    case 1:
                        if (s[i] != " ")
                        {
                            DateTime.TryParse(s[i], out d);
                            gameList = gameList.Where(game => game.releaseDate >= d).ToList();
                        }
                        break;
                    case 2:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.requiredAge >= Convert.ToInt32(s[i])).ToList();
                        }
                        break;
                    case 3:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.metacritic >= Convert.ToInt32(s[i])).ToList();
                        }
                        break;
                    case 4:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.recommendationCount == Convert.ToInt32(s[i])).ToList();
                        }
                        break;
                    case 5:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.controllSupport == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 6:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.platformWindows == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 7:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.platformLinux == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 8:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.platformMac == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 9:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.categorySinglePlayer == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 10:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.categoryMultiplayer == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 11:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.categoryCoop == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 12:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.categoryIncludeLevelEditor == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 13:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.categoryVRSupport == Convert.ToBoolean(s[i])).ToList();
                        }
                        break;
                    case 14:

                        if (s[14] != " ") { SortList(s[14]); }
                        break;
                    case 15:
                        if (s[i] != " ")
                        {
                            gameList = gameList.Where(game => game.id == Convert.ToInt32(s[i])).ToList();
                        }
                        break;
                }

            }
        }

        internal void SortList(string s)
        {
            switch (s)
            {
                case "ID":

                    gameList = gameList.OrderBy(game => game.id).ToList();
                    break;

                case "NAME":

                    gameList = gameList.OrderBy(game => game.name).ToList();
                    break;

                case "LAUNCH DATE":

                    gameList = gameList.OrderByDescending(game => game.releaseDate).ToList();
                    break;

                case "DLC":

                    gameList = gameList.OrderByDescending(game => game.dlcCount).ToList();
                    break;

                case "METACRITIC":

                    gameList = gameList.OrderByDescending(game => game.metacritic).ToList();
                    break;

                case "RECOMMENDATIONS":

                    gameList = gameList.OrderByDescending(game => game.recommendationCount).ToList();
                    break;

                case "OWNERS":

                    gameList = gameList.OrderByDescending(game => game.owners).ToList();
                    break;

                case "PLAYERS":

                    gameList = gameList.OrderByDescending(game => game.numberOfPlayers).ToList();
                    break;

                case "ACHIEVEMENTS":

                    gameList = gameList.OrderByDescending(game => game.achievementCount).ToList();
                    break;

                default:
                    gameList = gameList.OrderByDescending(game => game.id).ToList();
                    break;
            }
        }

        internal void PrintFiltered()
        {
            foreach (Game g in gameList)
            {
                g.PrintAllValues();
                
            }
        }
    }
}
