using System;

namespace InheritanceExercise
{
    class Program{
        static void Main(string[] args)
        {
            FourWheeledVehicles car = new FourWheeledVehicles();
            car.ChangeColor();

            car.StartVehicle();

        
        }
    }

    class Veicle{

    }

    class WheeledVehicles : Veicle
    {
        private string color;
        private decimal price;

        public string Color {get; set;}
        public decimal Price{get; set;}

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing \n The Color is changed");
        }
    }

    class FourWheeledVehicles: WheeledVehicles
    {   
        private string brandName;
        private int capacity;

        public string BrandName{get; set;}

        public int Capacity{get; set;}

        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }
    }
}