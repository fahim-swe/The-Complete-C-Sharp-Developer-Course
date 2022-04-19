using System;


namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.227;

            // ceiling 
            Console.WriteLine("Ceiling :" + System.Math.Ceiling(x));

            // floor    
            Console.WriteLine("Floor: " + System.Math.Floor(x));


            // round
            Console.WriteLine("Round: " + System.Math.Round(x,2));

            // truncate
            Console.WriteLine("Truncate : " + System.Math.Truncate(x));



            int a = 9;
            int b = 4;

            // Max
            Console.WriteLine(System.Math.Max(a,b));
            // Min

            // sqrt
            Console.WriteLine(System.Math.Sqrt(9));

            // pow(x,y) x^y

            Console.WriteLine(System.Math.Pow(2, 3));
            // Pi

            Console.WriteLine(System.Math.PI);


            // Random number between 1 to 10
            Random rand = new Random();

            Console.WriteLine("Random Number 1 to 10: " + rand.Next(1,10));


            double d = 0;
            d = rand.NextDouble()*1;

            Console.WriteLine("Random Double 0 to 1 double: " + d);
            Console.WriteLine("Random Number: " + rand.Next());
        }
    }
}