using System;

namespace Method
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = 5;
            b = 3;
            Console.WriteLine($" {a} + {b} = {addResult(a,b)}");

            GetName();
        }

        static int addResult(int a, int b)
        {
            return a+b;
        }

        static void GetName(){
            string name = string.Empty;
            name = Console.ReadLine();

            SayHi(name);
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Welcome back, {name}");
        }
    }
}