using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.name = "Fahim";
            Person.info();
        }
    }

    static class Person
    {
        static public string name;
        static public void info(){
            Console.WriteLine($"Hi, {name} are you");
        }
    }
}