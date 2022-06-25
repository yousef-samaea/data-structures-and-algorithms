using System;
using System.Diagnostics;
//using NODE.StacksandQueues;
//using NODE.stackqueuepseudo;
namespace NODE
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList newlist = new LinkedList();
            newlist.Insert(77);
            newlist.Insert(22);
            newlist.Insert(13);
            //newlist.AppendInEnd(122);
            //newlist.AddAfter(22, 4);
            //newlist.InsertBefore(22, 6);
            Console.WriteLine(newlist.lToString());
            //int kth = newlist.kthFromEnd(5);
            //Console.WriteLine("the search resalt is " + kth);

            ////*************************************************

            //Console.WriteLine("resalt for zipLists");
            //LinkedList list1 = new LinkedList();
            //LinkedList list2 = new LinkedList();
            //list1.Insert(55);
            //list1.Insert(66);
            //list1.Insert(77);
            //list2.Insert(12);
            //list2.Insert(13);
            //list2.Insert(14);

            //LinkedList nlist = new LinkedList();
            //nlist.zipLists(list1, list2);
            //Console.WriteLine(nlist.lToString());

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


            //PseudoQueue p = new PseudoQueue();
            //p.Enqueue(44);
            //p.Enqueue(55);
            //p.Enqueue(6);
            //p.Enqueue(77);
            //Console.WriteLine(p.PseudoQueuePrint());
            //Console.WriteLine("the Peeked value is :" + p.Peek());
            //p.Dequeue();
            //Console.WriteLine("the Peeked value after Dequeue is :" + p.Peek());
            //Console.WriteLine(p.PseudoQueuePrint());
            //Console.WriteLine();









        }



    }
}
