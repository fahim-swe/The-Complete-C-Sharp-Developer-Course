using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArrays
{
    class Program{
        static void Main(string[] args)
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = true;
            boolArray[1] = true;
            boolArray[2] = false;
            boolArray[3] = false;

            BitArray firstArray = new BitArray(4);
            BitArray secondArray = new BitArray(boolArray);


            firstArray.Set(0, false);
            firstArray.Set(1, false);
            firstArray.Set(2, false);
            firstArray.Set(3, false);

            foreach(var item in secondArray)
            {
                Console.WriteLine(item);
            }

            BitArray result = new BitArray(4);
            result = firstArray.And(secondArray);
            Console.WriteLine("AND");

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }


            result = firstArray.Or(secondArray);
            Console.WriteLine("OR");
            
            foreach(var item in result){
                Console.WriteLine(item);
            }


            result = firstArray.Not();
            foreach(var item in result){
                Console.WriteLine(item);
            }


        }
    }
}