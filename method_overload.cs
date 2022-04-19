using System;

namespace MethodOverloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{addNumbers(10,10,10)}");

            Console.WriteLine($"{addNumbers(10,10)}");
        }

        static int addNumbers(int a, int b, int c)
        {
            return a+b+c;
        }

        static int addNumbers(int a, int b)
        {
            return a+b;
        }
    }
}