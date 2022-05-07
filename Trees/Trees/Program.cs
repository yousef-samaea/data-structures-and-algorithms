using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree mytree = new BinaryTree();
            mytree.Add(6);
            mytree.Add(9);
            mytree.Add(5);
            mytree.Add(3);
            mytree.Add(77);
            Console.WriteLine("InOrder :");
            mytree.InOrder(mytree.RetutnRoot());
            Console.WriteLine();

            Console.WriteLine("POSTOrder :");
            mytree.POSTOrder(mytree.RetutnRoot());
            Console.WriteLine();

            Console.WriteLine("PreOrder :");
            mytree.PreOrder(mytree.RetutnRoot());
            Console.WriteLine();

            Console.Write("dos my tree contain 6 : ");
            Console.WriteLine(mytree.Contains(6));

            Console.Write("dos my tree contain 11 : ");
            Console.WriteLine(mytree.Contains(11));

            //var x = mytree.InOrder(mytree.Root);
            //foreach (var item in x)
            //{
            //    Console.Write($"{item},");
            //}
            Console.Write("The Maximum value in tree Is : ");
            Console.WriteLine(mytree.MaxTree(mytree.Root));
            Console.WriteLine();

        }
    }
}
