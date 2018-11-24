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

            return trySearch;

        }



        public void SortMenu()//print sort menu 
        {
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



        }

    }
}
