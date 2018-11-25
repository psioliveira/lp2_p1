using System;

namespace LP_P1
{
    class Renderer
    {
        public Renderer() { }

        //just one welcome
        public void Welcome() { Console.Write(" Welcome, "); }

        public bool MainMenu()//print main menu 
        {
            bool trySearch = false;

            Console.WriteLine(" select one option: ");
            Console.WriteLine("(01) SPECIFY ORDER TYPE");
            Console.WriteLine("(02) SEARCH FILTER");
            Console.WriteLine("(03) START SEARCH");
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
                    Console.WriteLine("aaa");
                    break;
                case 4: //exit program
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }

            return trySearch;
        }


        public bool[] SortMenu()//print sort menu 
        {
            bool[] sort = new bool[9];

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
            Console.WriteLine("(00) BACK");


            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Id selected");
                    sort[0] = true;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("name selected");
                    sort[1] = true;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("launch date selected");
                    sort[2] = true;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("metacritic selected");
                    sort[3] = true;
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("number of dlcs selected");
                    sort[4] = true;
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("recommendations selected");
                    sort[5] = true;
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("number of owners selected");
                    sort[6] = true;
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("number of players selected");
                    sort[7] = true;
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("number of achievements selected");
                    sort[8] = true;
                    break;

            }

            return sort;
        }

        public void SearchMenu()//print search menu 
        {
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
            bool[] sort = new bool[14];
            string[] data = new string[14];
            switch (answer)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                    data[0] = Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                    data[1] = Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[2] = Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[3] = Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[4] = Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[5] = Console.ReadLine();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[6] = Console.ReadLine();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[7] = Console.ReadLine();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[8] = Console.ReadLine();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[9] = Console.ReadLine();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[10] = Console.ReadLine();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[11] = Console.ReadLine();
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[12] = Console.ReadLine();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("enter the ID:");
                     data[13] = Console.ReadLine();
                    break;
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;
            }

        }


    }
}
