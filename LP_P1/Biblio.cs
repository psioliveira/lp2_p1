using System;
using System.Linq;
using System.Collections.Generic;

namespace LP_P1
{
    class Biblio
    {
        public FileManager file;//file with all games
        public Dictionary<int, Game> gameStorage;

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

                
                    biblio.Add(game.GetId(),game);
                
            }
            return biblio;
        }

        public List<Game> MakeSearch(Dictionary<int, Game> biblio, int key)
        {
            
            Dictionary<int, Game> Search = new Dictionary<int, Game>();
            List<Game> list = new List<Game>();

            list = biblio.Values.ToList();
            return list;
        }
        

    }




}

