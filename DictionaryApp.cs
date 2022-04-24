using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace DistionaryApp
{
    class Program{
        static void Main(string[] args)
        {
            Dictionary<string,string> capitals = new Dictionary<string, string>();


            Dictionary<int, string> names = new Dictionary<int, string>(){
                {1, "James"},
                {2, "Jack"},
                {3, "Emma"}
            };

            foreach(var item in names)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            

            // add
            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");

            // displaying
            foreach(var item in capitals){
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            for(int i = 0; i < capitals.Count; i++)
            {
                
                KeyValuePair<string,string> entry = capitals.ElementAt(i);
                Console.WriteLine(entry.Key + " -> " + entry.Value);
                
            }


            // idex
            Console.WriteLine("Indexing");
            Console.WriteLine(capitals["Italy"]);

            // try get value
            Console.WriteLine("Try get value");
            capitals.TryGetValue("Russia" ,out string result);
            if(result != null){
                Console.WriteLine("Resutl is " + result);
            }

            capitals.Clear();
            
        }
    }
}