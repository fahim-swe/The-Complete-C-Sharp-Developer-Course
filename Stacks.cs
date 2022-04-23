using System;
using System.Collections;
namespace Stacks 
{
    class Program{
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push("Hellow");
            stack.Push(4.5d);

          

            Console.WriteLine(stack.Peek());
            stack.Pop();

            Console.WriteLine(stack.Peek());
        }
    }
}