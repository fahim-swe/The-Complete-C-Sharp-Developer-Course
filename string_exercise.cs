using System;

namespace Execrise
{
    class Program 
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones    ";
            string seasonOne = "   - Season 1";
            string newName = "";

            // add " - Season 1"
            // without you determining the start index

            newName = tvShow.Insert(tvShow.Length, seasonOne);

            Console.WriteLine(newName);
        }
    }
}