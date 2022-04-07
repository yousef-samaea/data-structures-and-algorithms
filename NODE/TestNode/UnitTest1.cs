using System;
using Xunit;
using NODE;


namespace TestNode
{
    public class UnitTest1
    {
        //public static LinkedList linkedList = new LinkedList();
        [Fact]
        public void Test1()
        {
            LinkedList linkedList = new LinkedList();
            //Assert.Null(linkedList.head);
            linkedList.Insert(55);
            linkedList.Insert(66);
            linkedList.Insert(77);
            Assert.Equal("[ 77 ] -> [ 66 ] -> [ 55 ] -> NULL", linkedList.lToString());
        }


        //[Fact]
        //public void Test2()
        //{
        //    LinkedList x = new LinkedList();

        //    Assert.Equal(null, x.head);

        //    Assert.Null(x.head);

        //    LinkedList linkedList = new LinkedList();

        //    Assert.Equal("55", linkedList.Insert(55));

        //}

        [Fact]

        public void Test3()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(55);
            linkedList.Insert(66);
            linkedList.Insert(77);

            Assert.True(linkedList.Includes(55));
        }

        [Fact]
        public void AppndTest()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(55);
            linkedList.Insert(66);
            linkedList.Insert(77);
            linkedList.AppendInEnd(11);
            Assert.Equal("[ 77 ] -> [ 66 ] -> [ 55 ] -> [ 11 ] -> NULL", linkedList.lToString());
        }
        [Fact]
        public void AddAfterTest()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(55);
            linkedList.Insert(66);
            linkedList.Insert(77);
            linkedList.AddAfter(66, 11);
            Assert.Equal("[ 77 ] -> [ 66 ] -> [ 11 ] -> [ 55 ] -> NULL", linkedList.lToString());
        }

        [Fact]
        public void InsertBeforeTest()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(55);
            linkedList.Insert(66);
            linkedList.Insert(77);
            linkedList.InsertBefore(66, 11);
            Assert.Equal("[ 77 ] -> [ 11 ] -> [ 66 ] -> [ 55 ] -> NULL", linkedList.lToString());
        }


    }
}
