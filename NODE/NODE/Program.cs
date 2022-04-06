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
            Console.WriteLine(newlist.lToString());
        }
   


    }
}
