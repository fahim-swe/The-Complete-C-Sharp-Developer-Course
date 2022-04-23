using System;

using System.Collections;

namespace Queues
{
    class Program{
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("Fahim");
            queue.Enqueue("Abir");
            queue.Enqueue("Stakil");
            queue.Enqueue(2018831064);

            foreach(var item in queue){
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Count);

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());

            queue.Dequeue();
            Console.WriteLine(queue.Peek());


        }
    }
}