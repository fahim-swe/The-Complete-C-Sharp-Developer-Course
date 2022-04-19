using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string tvShow = "Game of Thrones";

            // Index of 
            Console.WriteLine(tvShow.IndexOf('o'));

            // Last Index of
            Console.WriteLine(tvShow.LastIndexOf('o'));


            // Substring
            Console.WriteLine(tvShow.Substring(0, 4));

            // Remove
            Console.WriteLine(tvShow.Remove(4));

            // Insert
            Console.WriteLine(tvShow.Insert(0, "The "));
        }
    }
}