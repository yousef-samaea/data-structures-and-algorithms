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
            Assert.True(validatebBrackets("()()()(){}{}[][][]"));
        }

        [Fact]
        public void TestTrue2()
        {
            Assert.True(validatebBrackets("()[[Extra Characters]]"));
        }

        [Fact]
        public void TestFalse1()
        {
            Assert.False(validatebBrackets("()("));
        }

        [Fact]
        public void TestFalse2()
        {
            Assert.False(validatebBrackets("[({text}]"));
        }

        [Fact]
        public void TestNull()
        {
            Assert.True(validatebBrackets(null));
        }


    }
}
