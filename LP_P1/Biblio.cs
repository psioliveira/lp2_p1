using System;
using System.Collections.Generic;

namespace LP_P1
{
    class Biblio
    {
        public FileManager file;//file with all games
        public HashSet<Game> gameStorage;

        public Biblio(FileManager file) //constructor 
        {
            this.file = file;
            gameStorage = CreateHashSet(file.gameList);
        }

        public HashSet<Game> CreateHashSet(string[] list)//generates hashset to be used as original list
        {
            HashSet<Game> biblio = new HashSet<Game>(); //new hashset with games objects

            for (int i = 1; i < list.Length; i++) //for each game in Games.csv file
            {
                string[] s = file.SplitLine(file.gameList[i]);//split each line into 24 arguments
                Game game = new Game(s); //generate new game object

                if (!biblio.Contains(game)) //ferify if the hashcode contains this game object already
                {
                    biblio.Add(game);
                }
            }
            return biblio;
        }

        public List<Game> MakeSearch(HashSet<Game> biblio, int key)
        {
            
            HashSet<Game> Search = new HashSet<Game>();
            List<Game> list = new List<Game>();
            

            foreach(Game g in Search)
            {
                list.Add(g);
            }
            return list;
        }
        

    }




}

