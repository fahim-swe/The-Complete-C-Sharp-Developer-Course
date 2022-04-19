using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];

            shapes[0] = new Shapes();
            shapes[1] = new Circle();
            shapes[2] = new Line();
            shapes[3] = new Triangle();

            foreach(var shape in shapes){
                Console.WriteLine(shape);
                shape.draw();

            }
        }
    }

    class Shapes
    {
        public virtual void draw()
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    class Line:Shapes
    {
        public new void draw()
        {
            Console.WriteLine("This is Line Draw");
        }
    }

     class Circle:Shapes
    {
        public override void draw()
        {
            Console.WriteLine("This is Circle Draw");
        }
    }

     class Triangle:Shapes
    {
        public override void draw()
        {
            Console.WriteLine("This is Triangle Draw");
        }
    }
}