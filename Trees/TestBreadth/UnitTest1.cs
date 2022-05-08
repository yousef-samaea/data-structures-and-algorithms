using System;
using Xunit;
using Trees;
using System.Collections.Generic;
namespace TestBreadth
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BreadthFirsts t = new BreadthFirsts();
            t.Addob(6);
            t.Addob(9);
            t.Addob(5);
            t.Addob(3);
            t.Addob(8);
            var x = new List<object> { 6, 5, 9, 3, 8 };
            Assert.Equal(x, t.BreadthFirst());



        }
    }
}
