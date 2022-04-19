using System;
namespace SealedClass
{
    class Program{
        
        static void Main(string[] args)
        {
            SealedClass sealedClass = new SealedClass();
            Console.WriteLine(sealedClass.add(10,20));
        }
    }

   
    // sealed class: a class that cannot be inherited by any class but can be instantiated..
    sealed class SealedClass{
        public int add(int a, int b)
        {
            return a+b;
        }
    }
}