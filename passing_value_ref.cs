using System;

namespace ValueAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Display(a, b);
            Modify(a,b);
            Display(a,b);

            PassByRef(ref a, ref b);
            Display(a,b);

        }

        static void PassByRef(ref int x, ref int y)
        {
            x = 3;
            y = 4;
            Display(x,y);
        }

        static void Modify(int x, int y)
        {
            x = 4;
            y = 5;
            Display(x,y);
        }
        static void Display(int x, int y)
        {
            Console.WriteLine(x + " " + y);
        }
    }
}