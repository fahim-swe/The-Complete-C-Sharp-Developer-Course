using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int.TryParse(Console.ReadLine(), out int val);

            int x = val;
            for(int i = 1; i <= x; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            
        }
    }
}