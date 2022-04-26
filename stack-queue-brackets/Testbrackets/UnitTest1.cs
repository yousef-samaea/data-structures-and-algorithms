using System;
using Xunit;
using stack_queue_brackets;
using static stack_queue_brackets.Program;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testbrackets
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrue1()
        {
            Assert.Equal(true, validatebBrackets("()()()(){}{}[][][]"));
        }

        [Fact]
        public void TestTrue2()
        {
            Assert.Equal(true, validatebBrackets("()[[Extra Characters]]"));
        }

        [Fact]
        public void TestFalse1()
        {
            Assert.Equal(false, validatebBrackets("()("));
        }

        [Fact]
        public void TestFalse2()
        {
            Assert.Equal(false, validatebBrackets("[({text}]"));
        }

        [Fact]
        public void TestNull()
        {
            Assert.Equal(true, validatebBrackets(null));
        }

       


    }
}
