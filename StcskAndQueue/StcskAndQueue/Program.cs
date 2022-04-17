using System;
using System.Diagnostics;
using NODE.StacksandQueues;
using NODE.stackqueuepseudo;
namespace NODE
{

    namespace StcskAndQueue
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Stack stack = new Stack();
                //stack.Push(22);
                //stack.Push(77);
                //stack.Push(66);
                //stack.Push(85);
                //stack.Push(78);
                //Console.WriteLine(stack.StackPrint());
                //Console.WriteLine("useing pop");
                //Console.WriteLine("the poped data is "+ stack.Pop());
                //Console.WriteLine(stack.StackPrint());
                //Console.WriteLine();


                //Queue queue = new Queue();
                //queue.Enqueue(14);
                //queue.Enqueue(13);
                //queue.Enqueue(55);
                //queue.Enqueue(99);
                //queue.Enqueue(72);
                //Console.WriteLine(queue.QueuePrint());
                //Console.WriteLine("useing Dequeue");
                //Console.WriteLine("the Dequeueed data is " + queue.Dequeue());
                //Console.WriteLine(queue.QueuePrint());
                //Console.WriteLine();


                PseudoQueue p = new PseudoQueue();
                p.Enqueue(44);
                p.Enqueue(55);
                p.Enqueue(6);
                p.Enqueue(77);
                Console.WriteLine(p.PseudoQueuePrint());
                Console.WriteLine("the Peeked value is :" + p.Peek());
                p.Dequeue();
                Console.WriteLine("the Peeked value after Dequeue is :" + p.Peek());
                Console.WriteLine(p.PseudoQueuePrint());
                Console.WriteLine();
            }
        }
    }
}
