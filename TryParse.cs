using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            x = int.Parse(Console.ReadLine());

            Console.WriteLine("You are Entering : " + x);

            int.TryParse(Console.ReadLine(), out int val);
            if(val == 0){
                Console.WriteLine("You enter invalid Key");
            }
            else{
                Console.WriteLine("You are Enter : " + val);
            }
        }
    }
}