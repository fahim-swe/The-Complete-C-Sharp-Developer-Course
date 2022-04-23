using System;
using System.Collections;

namespace SortedListDemo
{
    class Program{
        static void Main(string[] args)
        {
            // creating
            SortedList sortedList = new SortedList();
            // adding 
            sortedList.Add(10, "jan");
            sortedList.Add(2, "feb");
            sortedList.Add(3, "mar");
            sortedList.Add(4, "apr");
            sortedList.Add(5, "may");

            // displaying 
                // foreach
                foreach(DictionaryEntry item in sortedList){
                    Console.WriteLine(item.Key + ":  " + item.Value);
                }
                // for
                for(int i = 0; i < sortedList.Count; i++){
                    Console.WriteLine(sortedList.GetKey(i) + "-> " + sortedList.GetByIndex(i));
                }
            

            
            // index
            Console.WriteLine(sortedList[10].ToString());
            // capacity
            Console.WriteLine(sortedList.Count);
            // remove

            sortedList.Remove(10);
            foreach(DictionaryEntry item in sortedList){
                Console.WriteLine(item.Key + " " + item.Value);
            }
            // contains
            if(sortedList.ContainsValue("apr")){
                Console.WriteLine("true");
            }
            // copy to array

            ArrayList array = new ArrayList(sortedList.Values);

            foreach(var item in array){
                Console.Write(item + " ");
            }

        }
    }
}