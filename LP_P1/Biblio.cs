using System;
using System.Collections.Generic;

namespace LP_P1
{
    class Biblio
    {
        FileManager file;//file with all games

        public Biblio(FileManager file) //constructor 
        {
            this.file = file;
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

        public HashSet<Game> MakeSearch(HashSet<Game> biblio, int key)
        {

            bool last = false;
            HashSet<Game> Search = new HashSet<Game>();

            switch (key)
            {
                case 1:

                    do
                    {



                    } while (last == false);

                    break;

                case 2:

                    do
                    {



                    } while (last == false);

                    break;

                case 3:

                    do
                    {



                    } while (last == false);

                    break;

                case 4:

                    do
                    {



                    } while (last == false);

                    break;

                case 5:

                    do
                    {



                    } while (last == false);

                    break;

                case 6:

                    do
                    {



                    } while (last == false);

                    break;

                case 7:

                    do
                    {



                    } while (last == false);

                    break;

                case 8:

                    do
                    {



                    } while (last == false);

                    break;

                case 9:

                    do
                    {



                    } while (last == false);

                    break;

                case 10:

                    do
                    {



                    } while (last == false);

                    break;

                case 11:

                    do
                    {



                    } while (last == false);

                    break;

                case 12:

                    do
                    {



                    } while (last == false);

                    break;

                case 13:

                    do
                    {



                    } while (last == false);

                    break;

                case 14:

                    do
                    {



                    } while (last == false);

                    break;

                default:
                    break;


            }

            return Search;
        }
        

    }




}

