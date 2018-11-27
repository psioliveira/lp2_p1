using System;


namespace LP_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            FileManager File = new FileManager(path);
            ConsoleKeyInfo k = new ConsoleKeyInfo();
            Biblio biblio = new Biblio(File);
            do
            {
                Console.Clear();
                Renderer renderer = new Renderer();
                Selection selection = new Selection(biblio.MakeList(biblio.gameStorage), renderer);


                selection.StartFiltering();
                selection.PrintFiltered();

                Console.Write("you want to make another search? (1)yes or (0)no");
                k = Console.ReadKey();

            } while (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1);



            Console.Write("Program Finished. press any key to exit.");
            Console.ReadKey();

        }
    }
}
