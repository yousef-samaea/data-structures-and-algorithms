using System;
using Xunit;
using NODE;
namespace TestNode
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LinkedList linkedList = new LinkedList();
            
 
            
            Assert.Equal(0, linkedList.kthFromEnd(11));
        }
    }
}
