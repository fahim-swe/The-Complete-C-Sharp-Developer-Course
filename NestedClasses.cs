using System;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            
            Animals.Dogs dogs = new Animals.Dogs();

            Animals.Cats cats = new Animals.Cats();
        }
    }

    class Animals
    {
        public string animalName;
        public string animalCountry;

        public class Dogs
        {
            public string dogsName;

        }

        public class Cats
        {
            public string catName;
        }
    }
}