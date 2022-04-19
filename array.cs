using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {1, 2, 3, 4, 5};

            string[] weekdays = {"sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

            for(int i = 0; i < numbers.Length; i++){
                Console.WriteLine(i);
            }


            foreach(string name in weekdays){
                Console.WriteLine(name);
            }
        }
    }
}