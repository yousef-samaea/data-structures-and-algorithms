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

            //*************************************************

            Console.WriteLine("resalt for zipLists");
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(55);
            list1.Insert(66);
            list1.Insert(77);
            list2.Insert(12);
            list2.Insert(13);
            list2.Insert(14);

            LinkedList nlist = new LinkedList();
            nlist.zipLists(list1, list2);
            Console.WriteLine(nlist.lToString());
        }
   


    }
}
