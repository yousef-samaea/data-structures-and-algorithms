using System;
using Xunit;
using Trees;
using System.Collections.Generic;



namespace Testtrees
{
    public class UnitTest1
    {



        [Fact]
        public void TestSingleTreeNode()
        {
            BinaryTree mytree = new BinaryTree();
            mytree.Add(66);
            Assert.Equal(66, mytree.Root.Value);
        }

        [Fact]
        public void Testcopy()
        {
            BinaryTree mytree = new BinaryTree();
            Assert.NotNull(mytree);
        }


        //[Fact]
        //public int TestInOrder()
        //{
        //    BinaryTree mytree = new BinaryTree();
        //    mytree.Add(6);
        //    mytree.Add(9);
        //    mytree.Add(5);
        //    mytree.Add(3);
        //    mytree.Add(77);

        //    //3 5 6 9 77
        //    //int[] arr = { 3, 5, 6, 9, 77 };
        //    //int[] arr2 = mytree.InOrder(mytree.Root);
        //    List<int> list = new List<int>();
        //    list.Add(3); list.Add(5); list.Add(6); list.Add(9); list.Add(77);
        //    mytree.InOrder(mytree.RetutnRoot());
        //    Console.WriteLine(mytree.Root.Value);
        //    mytree.RetutnRoot();
            //int x = mytree.InOrder(mytree.RetutnRoot());
            //Assert.Equal(list, mytree.InOrder(mytree.RetutnRoot()));
            //Assert.Equal(list, mytree.InOrder(mytree.RetutnRoot()));
            //Assert.Equal(Console.WriteLine(mytree.Root.Value), mytree.Root.Value);
        }


        //[Fact]
        //public void Test3()
        //{
        //    BinaryTree mytree = new BinaryTree();
        //    Assert.NotNull(mytree);
        //}

        



    }
