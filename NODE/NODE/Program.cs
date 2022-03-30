using System;
using System.Diagnostics;

namespace NODE
{
    public class Program
    {
        static void Main(string[] args)
        {
        
        }
        public class Node
        {
            public int data;
            public Node next;
            public Node(int x) // constructor that take new data that i want to put in list
            {
                data = x;
                next = null;
            }
        }


        public class LinkedList
        {
            Node head;
            public LinkedList()
            {
                head = null;
                // int count = 0;
            }
            public void Insert(int data)
            {

                Node node = new Node(data);
                node.next = head;
                head = node;
                //  count++
            }
            //public void PrintList()
            //{
            //    Node runner = head;
            //    while (runner != null)
            //    {
            //        Console.WriteLine(runner.data);
            //    }
            //}

            public void ToSstring()
            {
                Node n = head;
                if (n == null)
                {
                    Console.WriteLine("Your llist is empty");
                }
                else
                {
                    while (n != null)
                    {
                        Console.Write("[" + n.data + "] -> ");
                        n = n.next;
                    }
                    Console.WriteLine("null");
                }
            }


        }


    }
}
