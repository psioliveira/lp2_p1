using System.Linq;
using System.Collections.Generic;

namespace LP_P1
{
    
    internal class Biblio
    {/// <summary>
     /// Class used for generate the dictionary and the list who is used for search and sort the games objects
     /// </summary>
        internal FileManager file;//file with all games
        internal Dictionary<int, Game> gameStorage;

        public Biblio(FileManager file) //constructor 
        {
            this.file = file;
            gameStorage = CreateDictionary(file.gameList);
        }

        /// <summary>
        /// methods to generate the dictionary with all games in the csv file
        /// </summary>
        /// <param name="list">list with all strings from csv file</param>
        /// <returns></returns>
        internal Dictionary<int, Game> CreateDictionary(string[] list)//generates hashset to be used as original list
        {
            Dictionary<int, Game> biblio = new Dictionary<int, Game>(); //new hashset with games objects

            for (int i = 1; i < list.Length; i++) //for each game in Games.csv file
            {
                string[] s = file.SplitLine(file.gameList[i]);//split each line into 24 arguments
                Game game = new Game(s); //generate new game object

                if (biblio.TryGetValue(game.id, out Game g) == false)
                {
                    biblio.Add(game.id, game); //add one game into the Dictionary with ID as key
                }
            }
            return biblio;
        }

        /// <summary>
        /// methos to geenrate the list with all games objects in the Dictionary.
        /// </summary>
        /// <param name="biblio">Dictionary who have all game objects.</param>
        /// <returns></returns>
        internal List<Game> MakeList(Dictionary<int, Game> biblio)
        {
            List<Game> list = new List<Game>();
            list = biblio.Values.ToList(); //generate one list with all Game objects inside this Dictionary
            return list;
        }

        /// <summary>
        /// metho to return one game object with one especific id.
        /// </summary>
        /// <param name="biblio">dictionary with all games.</param>
        /// <param name="key">game id, used as key in the Dictionary.</param>
        /// <returns></returns>
        internal Game MakeSearch(Dictionary<int, Game> biblio, int key)
        {
            biblio.TryGetValue(key, out Game game);//return one Game object with a especific ID
            return game;
        }
    }
}

