using System;

namespace CarsExercise
{
    class Program{
        static void Main(string[] args)
        {
            Cars cars = new Cars();

            cars.displayInfo();

            Mercedes mercedes = new Mercedes();
            mercedes.displayInfo();
        }
    }
    

    #region  Cars: base Car Class
    class Cars
    {
        private decimal price;
        protected int maxSpeed;

        public string color;

        protected decimal Price
        {
            set{price = value;}
            get{return price;}
        }

        public virtual void displayInfo()
        {
            price = 10000;
            maxSpeed = 300;
            color = "Black";

            Console.WriteLine($"Base Class Car Price : {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }


    #endregion
    class Mercedes: Cars
    {
        public override void displayInfo()
        {
            base.displayInfo();

            base.Price = 15000;
            base.color = "White";
            base.maxSpeed = 200;

            Console.WriteLine($"Clild Class Car Price : {base.Price}, max speed is {base.maxSpeed} and the color is {base.color}");
        }
    }
}