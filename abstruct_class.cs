using System;

namespace Abstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.sayHi();
            line.Draw();
        }
    }

    abstract class Shapes{
        abstract public void Draw();

        public void sayHi()
        {
            Console.WriteLine("Hi, form abstract shapes");
        }
    }


    class Line:Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Hi, this is line");
        }
    }
}