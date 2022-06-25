using System;
using Xunit;
using Hash_Table;
using System.Collections.Generic;
using static Hash_Table.Program;

namespace TestTreeIntersection
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tree mytree = new Tree();
            mytree.Add(6);
            mytree.Add(9);
            mytree.Add(5);
            mytree.Add(3);
            mytree.Add(77);
            Tree mytree2 = new Tree();
            mytree2.Add(4);
            mytree2.Add(2);
            mytree2.Add(6);
            mytree2.Add(3);
            mytree2.Add(44);

            List<int> common = new List<int>() { 3,6 };

            Assert.Equal(common, TreeIntersection(mytree, mytree2));
        }


        [Fact]
        public void Test2()
        {
            Tree mytree = new Tree();
            mytree.Add(6);
            mytree.Add(9);
            mytree.Add(5);
            mytree.Add(3);
            mytree.Add(77);
            Tree mytree2 = new Tree();
            mytree2.Add(4);
            mytree2.Add(2);
            mytree2.Add(6);
            mytree2.Add(3);
            mytree2.Add(44);

            List<int> common = new List<int>() { 4, 6 };

            Assert.NotEqual(common, TreeIntersection(mytree, mytree2));
        }

    }
}
