using System;
using Xunit;
using Hash_Table;
using System.Collections.Generic;
using static Hash_Table.Program;

namespace TestRepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void TestRepeatedWord()
        {
            string x = "Once upon a time, there was a brave princess who...";
            Assert.Equal("a", RepeatedWord(x));
        }

        [Fact]
        public void TestRepeatedWord2()
        {
            string x = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            Assert.Equal("the", RepeatedWord(x));
        }

        [Fact]
        public void TestEmpty()
        {
            string x = "";
            Assert.Equal("ther is no Repeated Words", RepeatedWord(x));
        }

       







    }
}
