using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "    lord l of the RING    ";


            // Indexs
            Console.WriteLine(movieName[17]);

            // Trim
            Console.WriteLine(movieName.Trim());

            // Upper case
            Console.WriteLine(movieName.ToLower());


            // Length
            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);

            // replace
            Console.WriteLine(movieName.Replace('l', 'L').Trim());
        }
    }
}