using System;
using System.Diagnostics;

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
            newlist.AppendInEnd(122);
            newlist.AddAfter(22, 4);
            newlist.InsertBefore(22, 6);
            Console.WriteLine(newlist.lToString());
            int kth = newlist.kthFromEnd(5);
            Console.WriteLine("the search resalt is " + kth);
        }
   


    }
}
