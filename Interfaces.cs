using System;

namespace Interface {
    class Program{
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.attack();
            dog.sayHi();
            IDogCommands idog = new Dog();
            idog.sit();
        }
    }

    class Animals
    {
        string animalName;
        public void sayHi()
        {
            Console.WriteLine("Hello, Dog");
        }
    }
    public interface IDogCommands
    {
        void stay();
        void sit();
        void attack();
        
        string dogName{
            set;
            get;
        }
    }

    class Dog:Animals, IDogCommands
    {
        private string dogBreed;

        public void stay()
        {
            Console.WriteLine("Dog is staying");
        }

        public void sit()
        {
            Console.WriteLine("Dog is sitting");
        }

        public void attack()
        {
            Console.WriteLine("Dog is attracking");
        }

        public string dogName{
            get; set;
        }
    }
}