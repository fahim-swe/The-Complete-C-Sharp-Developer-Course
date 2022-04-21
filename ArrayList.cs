using System;

namespace ArrayListDemo
{
    class Program{
        static void Main(string[] args)
        {
            // creating

            System.Collections.ArrayList array = new System.Collections.ArrayList();
           
            // adding
            array.Add("First");
            array.Add("Second");
            array.Add(3);
            array.Add(4.5d);

            
            printArray(array);
         
            array.Insert(2, "Third");
            printArray(array);

            // index
            Console.WriteLine(array[2].ToString());


            // capacity
            Console.WriteLine("Count is :" + array.Count);

            array.Clear();
            array.Add(5);
            array.Add(2);
            array.Add(4);
            array.Add(2);
            array.Add(4);
            array.Add(2);
            array.Add(4);
            // sorting
            array.Sort();
            Console.WriteLine("After sorting: ");
            printArray(array);

            // reversing
            array.Reverse();
            printArray(array);

            // removing 

            array.RemoveAt(0);
            printArray(array);

            // remove all

            // contains
            if(array.Contains(2)){
                Console.WriteLine("True");
            }

            // get range
            // copy

            System.Collections.ArrayList newArray = new System.Collections.ArrayList();
            printArray(array);
            newArray = array.GetRange(0, 3);
            printArray(newArray);
        }


        static void printArray(System.Collections.ArrayList array)
        {
            Console.WriteLine("----------------");
            foreach(var item in array){
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }
    }

 
}