using System;
using System.Collections.Generic;

namespace ListApp
{
    class Program{
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();

            // Adding 
            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");
            firstList.Add("Egypt");

            // displaying
            foreach(var item in firstList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // idex
            Console.WriteLine(firstList[0]);


            // capacity 
            Console.WriteLine(firstList.Count);

            // sorring
            firstList.Sort();
            foreach(var item in firstList){
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("After Reversing... ");
            firstList.Reverse();
            foreach(var item in firstList){
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing ...");
            firstList.Remove("China");
            foreach(var item in firstList){
                Console.Write(item + " ");
            }

            Console.WriteLine("Removing at ....");
            firstList.RemoveAt(2);
            foreach(var item in firstList){
                Console.Write(item + " ");
            }

            Console.WriteLine();

            secondList = firstList.GetRange(1, 2);
            Console.WriteLine(secondList.Count);
            foreach(var item in secondList){
                Console.Write(item + " ");
            }
        }
    }
}