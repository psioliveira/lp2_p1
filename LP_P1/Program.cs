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
            Biblio biblio = new Biblio(File);
            Renderer renderer = new Renderer();
            Selection selection = new Selection(biblio.MakeList(biblio.gameStorage), renderer);

            selection.StartFiltering();
          
        }
    }
}
