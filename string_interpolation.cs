using System;

namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");

            string name = "";
            name = Console.ReadLine();

            Console.WriteLine("My name is {0}", name);
        }
    }
}