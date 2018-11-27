using System;

namespace LP_P1
{
    internal class Renderer
    {
        /// <summary>
        /// 
        /// </summary>
        public Renderer() { }

        //initializes one array of strings
        internal string[] values = new string[16] { " ", " ", " ", " ", " ",
                                                    " ", " ", " ", " ", " ",
                                                    " ", " ", " ", " ", " ", " "};
        
        public void Menu()//print main menu 
        {
            Console.WriteLine(" SELECT AN OPTION ");
            Console.WriteLine("(01) SELECT ONE GAME");
            Console.WriteLine("(02) MAKE ONE SEARCH");
            Console.WriteLine("(00) QUIT");

            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1: //add sort type
                    Console.Clear();
                    Console.WriteLine("INSERT ONE ID: ");
                    values[15] = Console.ReadLine();
                    break;

                case 2: //go to option menu
                    Console.Clear();
                    OptionMenu();
                    break;
                case 0: //exit program
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
           
        }

        public void OptionMenu()//print main menu 
        {
            Console.WriteLine(" select one option: ");
            Console.WriteLine("(01) SPECIFY ORDER TYPE");
            Console.WriteLine("(02) SEARCH FILTER");
            Console.WriteLine("(03) START SEARCH");
            Console.WriteLine("");
            Console.WriteLine("(04) CLEAR ALL OPTIONS");
            Console.WriteLine("(00) BACK");
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
                    break;
                    
                case 4: //reset values
                    Console.Clear();

                    Console.WriteLine("VALUES RESETED");
                    values = new string[16] { " ", " ", " ", " ", " ", " "," ",
                                        " ", " ", " ", " ", " "," "," "," "," "};
                    break;
                case 0: //go to main menu
                    Console.Clear();
                    Menu();
                    break;
            }
        }


        public void SortMenu()//print sort menu 
        {

        	Console.WriteLine("selected:{0} ", values[14]);
            Console.WriteLine("");
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
                    SortMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("name selected");
                    values[14] = "NAME";
                    SortMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("launch date selected");
                    values[14] = "LAUNCH DATE";
                    SortMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("metacritic selected");
                    values[14] = "METACRITIC";
                    SortMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("number of dlcs selected");
                    values[14] = "DLCS";
                    SortMenu();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("recommendations selected");
                    values[14] = "RECOMMENDATIONS";
                    SortMenu();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("number of owners selected");
                    values[14] = "OWNERS";
                    SortMenu();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("number of players selected");
                     values[14] = "PLAYERS";
                    SortMenu();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("number of achievements selected");
                    values[14] = "ACHIEVEMENTS";
                    SortMenu();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("SORT CLEARED");
                    values[14] = " ";
                    SortMenu();
                    break;

                case 0:
                    Console.Clear();
                    OptionMenu();
                    break;
            }
        }

        public void SearchMenu()//print search menu 
        {   
        	Console.WriteLine("SELECTED: {0} {1} {2} {3} {4} {5} {6}"
        							  +" {7} {8} {9} {10} {11} {12} {13}",
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
            Console.WriteLine("(05) RECOMMENDATIONS");
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
                    SearchMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter the DATE: (Example: Nov 1 2000)");
                    values[1] = Console.ReadLine();
                    SearchMenu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("enter the AGE:");
                    values[2] = Console.ReadLine();
                    SearchMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("enter the METACRITIC(int value):");
                    values[3] = Console.ReadLine();
                    SearchMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("enter the RECOMMENDATIONS:");
                    values[4] = Console.ReadLine();
                    SearchMenu();
                    break;
                case 6:
                    Console.Clear();
                    values[5] = "true";
                    SearchMenu();
                    break;
                case 7:
                    Console.Clear();
                    values[6] = "true";
                    SearchMenu();
                    break;
                case 8:
                    Console.Clear();
                    values[7] = "true";
                    SearchMenu();
                    break;
                case 9:
                    Console.Clear();
                    values[8] = "true";
                    SearchMenu();
                    break;
                case 10:
                    Console.Clear();
                    values[9] = "true";
                    SearchMenu();
                    break;
                case 11:
                    Console.Clear();
                    values[10] = "true";
                    SearchMenu();
                    break;
                case 12:
                    Console.Clear();
                    values[11] = "true";
                    SearchMenu();
                    break;
                case 13:
                    Console.Clear();
                    values[12] = "true";
                    SearchMenu();
                    break;
                case 14:
                    Console.Clear();
                    values[13] = "true";
                    SearchMenu();
                    break;
                case 0:
                    Console.Clear();
                    OptionMenu();
                    break;
            }
        }
    }
}
