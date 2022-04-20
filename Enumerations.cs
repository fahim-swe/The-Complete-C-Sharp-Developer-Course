using System;

namespace Enumerations
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDay.Friday);


            Console.WriteLine((int)WeekDay.Saturday);
        }
    }

    enum WeekDay
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 40,
        Saturday = 50,
        Sunday = 60
    }
}