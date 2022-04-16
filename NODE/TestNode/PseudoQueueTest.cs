using System;
using Xunit;
using NODE;
using NODE.stackqueuepseudo;

namespace TestNode
{
    public class PseudoQueueTest
    {
        [Fact]
        public void TestEequeue()
        {
            PseudoQueue p = new PseudoQueue();
            p.Enqueue(44);
            p.Enqueue(55);
            p.Enqueue(66);
            

            Assert.Equal(44, p.Peek());
        }

        [Fact]
        public void TestEequeue2()
        {
            PseudoQueue p = new PseudoQueue();
            p.Enqueue(44);
            p.Enqueue(55);
            p.Enqueue(66);
            Assert.Equal("[ 44 ] -> [ 55 ] -> [ 66 ] -> NULL", p.PseudoQueuePrint());
        }



        [Fact]
        public void TestDequeue()
        {
            PseudoQueue p = new PseudoQueue();
            p.Enqueue(44);
            p.Enqueue(55);
            p.Enqueue(66);
            p.Dequeue();
            Assert.Equal(55, p.Peek());
        }


        [Fact]
        public void TestDequeue2()
        {
            PseudoQueue p = new PseudoQueue();
            p.Enqueue(44);
            p.Enqueue(55);
            p.Enqueue(66);
            p.Dequeue();
            Assert.Equal("[ 55 ] -> [ 66 ] -> NULL", p.PseudoQueuePrint());
        }

        [Fact]
        public void QueueEmptyPeekTest()
        {
            PseudoQueue p = new PseudoQueue();
            Assert.Throws<InvalidOperationException>(() => p.Peek());
        }


    }
}
