using System;


namespace LP_P1
{
    class Program
    {/// <summary>
    /// main program
    /// </summary>
    /// <param name="args">Command line arguments, used for open the file.</param>
        static void Main(string[] args)
        {
            string path = args[0]; //select the File path as the first comand line argument 
            FileManager File = new FileManager(path); //instantiate one File object
            ConsoleKeyInfo k = new ConsoleKeyInfo(); //instantiate one ConsoleKeyInfo for future use
            Biblio biblio = new Biblio(File); //instantiate new Biblio object who contains one Dictionary and one List
            do
            {
                Console.Clear(); //clear console
                Renderer renderer = new Renderer(); //create a new renderer in each loop
                Selection selection = new Selection(biblio.MakeList(biblio.gameStorage), renderer);//create a new selection object in each loop


                selection.StartFiltering(); //filter the games inside the list
                selection.PrintFiltered(); //print values of each object inside the list on screen and download the header immage
                selection.OpnIMG();

                Console.Write("you want to make another search? (1)yes or (0)no");
                k = Console.ReadKey(false);//confirm if the user want to do another search or close the program 

            } while (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1);



            Console.Write("Program Finished. press any key to exit.");
            Console.ReadKey(false);

        }
    }
}
