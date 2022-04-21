using System;
using System.Collections;
namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating
            Hashtable hashtable = new Hashtable();
            // adding

            hashtable.Add("fahim", "Software engineeing");
            hashtable.Add(1, 1000);
            hashtable.Add("sakil", 2018831072);
            hashtable.Add("Microsoft", "USA");


            foreach(DictionaryEntry item in hashtable )
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

             
            // capacity
            Console.WriteLine("Count item : " + hashtable.Count);

            // remove
            hashtable.Remove(1);
              // capacity
            Console.WriteLine("Count item : " + hashtable.Count);

            foreach(DictionaryEntry item in hashtable )
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }


            // contains 
            if(hashtable.Contains("fahim")){
                Console.WriteLine(hashtable["fahim"]);
            }
            // copy to arrayList

            ArrayList arrayList = new ArrayList(hashtable.Values);

            for(int i = 0; i < arrayList.Count; i++){
                Console.WriteLine(arrayList[i]);
            }


        }
    }
}