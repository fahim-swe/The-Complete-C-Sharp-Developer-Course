using System;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOwnNamespace.Animals animals = new MyOwnNamespace.Animals();
            MyOwnNamespace.Trainers trainers = new MyOwnNamespace.Trainers();
        }
    }
}   

namespace MyOwnNamespace
{
    class Animals{

    }

    class Trainers
    {

    }
}