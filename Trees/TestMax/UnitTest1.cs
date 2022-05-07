using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TestMax
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaxTreePositive()
        {
            BinaryTree mytree = new BinaryTree();
            mytree.Add(6);
            mytree.Add(9);
            mytree.Add(5);
            mytree.Add(3);
            mytree.Add(77);
            Assert.Equal(77, mytree.MaxTree(mytree.Root));
        }

        [Fact]
        public void TestMaxTreeNegative()
        {
            BinaryTree mytree = new BinaryTree();
            mytree.Add(-6);
            mytree.Add(-9);
            mytree.Add(-95);
            mytree.Add(-5);
            mytree.Add(-88);
            Assert.Equal(-5, mytree.MaxTree(mytree.Root));
        }

        [Fact]
        public void TestMaxTree()
        {
            BinaryTree mytree = new BinaryTree();
            mytree.Add(15);
            mytree.Add(4);
            mytree.Add(81);
            mytree.Add(4);
            mytree.Add(5);
            Assert.NotEqual(99, mytree.MaxTree(mytree.Root));
        }

    }
}
