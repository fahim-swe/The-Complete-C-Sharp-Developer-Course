using System;
using System.Collections;
using System.Collections.Generic;

namespace AnimalsAndTrainersExercise
{
    class Program{
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "max";

            Animals cat = new Animals();
            cat.Name = "Lucy";

            Animals elephant = new Animals();
            elephant.Name = "Fofy";

            Trainers john = new Trainers();
            john.TrainerName = "John Jackson";

            ArrayList arrayList = new ArrayList();

            arrayList.Add(dog);
            arrayList.Add(cat);
            arrayList.Add(elephant);
            arrayList.Add(john);

    

            foreach(var item in arrayList)
            {
                if(typeof(Animals) == item.GetType()){
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else{
                    ((Trainers)item).sayHi();
                }
            }

                 
        }
    }

    struct Animals{
        private string name;
        public string Name{
            set{name = value;}
            get{return name;}
        }

        public void SayHi()
        {
            Console.WriteLine("Hello, my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eatting");
        }
    }

    struct Trainers 
    {
        private string trainerName;
        public string TrainerName{
            get{return trainerName;}
            set{trainerName = value;}
        }

        public void sayHi()
        {
            Console.WriteLine("I am your new trainer  " + trainerName);
        }
    }
}