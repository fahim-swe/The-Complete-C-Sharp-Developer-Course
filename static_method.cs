using System;
namespace StaticMethod
{
    class Program{
        static void Main(string[] args)
        {
            sayHi();

            Program program = new Program();
            program.sayHello();
        }

        static void sayHi()
        {
            Console.WriteLine("Hi, This is static Method");
        }

        public void sayHello()
        {
            Console.WriteLine("Hi, This is non static Method");
        }
    }
}