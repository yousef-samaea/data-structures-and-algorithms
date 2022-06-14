using System;
using Xunit;
using Hash_Table;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void TestGet()
        {
            HashTable node = new HashTable();
            node.Set("1", "yousef");

            Assert.Equal("yousef", node.Get("1").Value);
        }

        [Fact]
        public void TestHashing()
        {
            HashTable node = new HashTable();
            node.Set("1", "yousef");
            node.Set("2", "samara");

            Assert.Equal("yousef", node.Get("1").Value);
            Assert.Equal("samara", node.Get("2").Value);
        }


        [Fact]
        public void TestContains()
        {
            HashTable node = new HashTable();
            node.Set("1", "yousef");

            Assert.True(node.Contains("1"));
        }



    }
}
