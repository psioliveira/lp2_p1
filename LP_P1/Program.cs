using System;
using System.IO;


namespace LP_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            FileManager File = new FileManager(path);
            do
            {
                Console.Clear();
                Biblio biblio = new Biblio(File);
                Renderer renderer = new Renderer();
                Selection selection = new Selection(biblio.MakeList(biblio.gameStorage), renderer);


                selection.StartFiltering();
                selection.PrintFiltered();

                Console.Write("you want to make another search? (1)yes or (0)no");
             
            } while (Console.ReadKey().Key == ConsoleKey.Y);



            Console.Write("Program Finished. press any key to exit.");
            Console.ReadKey();

        }
    }
}
