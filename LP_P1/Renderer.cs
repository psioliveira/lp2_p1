﻿using System;

namespace LP_P1
{
    class Renderer
    {
        public Renderer() { }

        public string[] values = new string[15] { " ", " ", " ", " ", " ", " ",
                                                  " ", " ", " ", " ", " ", " ",
                                                                  " "," "," "};



        //just one welcome
        public void Welcome() { Console.Write(" Welcome, "); }

        public bool MainMenu()//print main menu 
        {
            bool trySearch = false;

            Console.WriteLine(" select one option: ");
            Console.WriteLine("(01) SPECIFY ORDER TYPE");
            Console.WriteLine("(02) SEARCH FILTER");
            Console.WriteLine("(03) START SEARCH");
            Console.WriteLine("(04) SEARCH BY ID");
            Console.WriteLine("(00) QUIT");

            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1: //add sort type
                    Console.Clear();
                    SortMenu();
                    break;
                case 2: //add search filter
                    Console.Clear();
                    SearchMenu();
                    break;
                case 3: //search
                    Console.Clear();
                    trySearch = true;
                    Console.WriteLine("aaa");
                    break;
                case 4: //search
                    Console.Clear();
                    trySearch = true;
                    Console.WriteLine("aaa");
                    break;
                case 0: //exit program
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }

            return trySearch;
        }


        public void SortMenu()//print sort menu 
        {

        	Console.WriteLine("selected:{0} ", values[14]);
            Console.WriteLine("select one sort type: ");
            Console.WriteLine("(01) ID");
            Console.WriteLine("(02) NAME");
            Console.WriteLine("(03) LAUNCH DATE");
            Console.WriteLine("(04) METACRITIC");
            Console.WriteLine("(05) NUMBER OF DLCs");
            Console.WriteLine("(06) RECOMENDATIONS");
            Console.WriteLine("(07) NUMBER OF OWNERS");
            Console.WriteLine("(08) NUMBER OF PLAYERS");
            Console.WriteLine("(09) NUMBER OF ACHIEVEMENTS");
            Console.WriteLine("");
            Console.WriteLine("(10) CLEAR");
            Console.WriteLine("(00) BACK");


            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Id selected");
                    values[14] = "ID";
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("name selected");
                    values[14] = "NAME";
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("launch date selected");
                    values[14] = "LAUNCH DATE";
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("metacritic selected");
                    values[14] = "METACRITIC";
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("number of dlcs selected");
                    values[14] = "DLCS";
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("recommendations selected");
                    values[14] = "RECOMMENDATIONS";
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("number of owners selected");
                    values[14] = "OWNERS";
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("number of players selected");
                     values[14] = "PLAYERS";
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("number of achievements selected");
                    values[14] = "ACHIEVEMENTS";
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("SORT CLEARED");
                    values[14] = "NONE";
                    break;

            }
            
        }

        public void SearchMenu()//print search menu 
        {   
        	Console.WriteLine("SELECTED: {0} {0} {0} {0} {0} {0} {0}"
        							   +" {0} {0} {0} {0} {0} {0} {0}",
        							   values[0],values[1],values[2],
        							   values[3],values[4],values[5],
        							   values[6],values[7],values[8],
        							   values[9],values[10],values[11],
        							   			 values[12],values[13]);
        	Console.WriteLine("Search by: ");
            Console.WriteLine("(01) NAME");
            Console.WriteLine("(02) DATE");
            Console.WriteLine("(03) AGE");
            Console.WriteLine("(04) METACRITIC");
            Console.WriteLine("(05) RECOMENDATIONS");
            Console.WriteLine("(06) CONTROLLER SUPPORT");
            Console.WriteLine("(07) FOR WINDOWS");
            Console.WriteLine("(08) FOR LINUX");
            Console.WriteLine("(09) FOR MAC");
            Console.WriteLine("(10) SINGLEPLAYER");
            Console.WriteLine("(11) MULTIPLAYER");
            Console.WriteLine("(12) COOPERATIVE");
            Console.WriteLine("(13) LEVEL EDITOR");
            Console.WriteLine("(14) VR READY");
            Console.WriteLine("(00) BACK");

            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("enter the NAME:");
                    values[0] = Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter the DATE:");
                    values[1] = Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("enter the AGE:");
                    values[2] = Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("enter the METACRITIC:");
                    values[3] = Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    values[4] = "true";
                    break;
                case 6:
                    Console.Clear();
                    values[5] = "true";
                    break;
                case 7:
                    Console.Clear();
                    values[6] = "true";
                    break;
                case 8:
                    Console.Clear();
                    values[7] = "true";
                    break;
                case 9:
                    Console.Clear();
                    values[8] = "true";
                    break;
                case 10:
                    Console.Clear();
                    values[9] = "true";
                    break;
                case 11:
                    Console.Clear();
                    values[10] = "true";
                    break;
                case 12:
                    Console.Clear();
                    values[11] = "true";
                    break;
                case 13:
                    Console.Clear();
                    values[12] = "true";
                    break;
                case 14:
                    Console.Clear();
                    values[13] = "true";
                    break;
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;
            }

        }


    }
}
