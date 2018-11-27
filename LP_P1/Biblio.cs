using System.Linq;
using System.Collections.Generic;

namespace LP_P1
{
    internal class Biblio
    {
        internal FileManager file;//file with all games
        internal Dictionary<int, Game> gameStorage;

        public Biblio(FileManager file) //constructor 
        {
            this.file = file;
            gameStorage = CreateDictionary(file.gameList);
        }

        public Dictionary<int, Game> CreateDictionary(string[] list)//generates hashset to be used as original list
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

        public List<Game> MakeList(Dictionary<int, Game> biblio)
        {
            List<Game> list = new List<Game>();
            list = biblio.Values.ToList(); //generate one list with all Game objects inside this Dictionary
            return list;
        }

        public Game MakeSearch(Dictionary<int, Game> biblio, int key)
        {
            biblio.TryGetValue(key, out Game game);//return one Game object with a especific ID
            return game;
        }
    }
}

