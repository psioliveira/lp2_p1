using System;
using System.IO;


namespace LP_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pedro\source\repos\lp2_2018_p1\Games.csv";

            string[] gameList = File.ReadAllLines(path);
            Game teste = new Game(gameList[1]);
            teste.PrintAllValues();

        }
    }
}
