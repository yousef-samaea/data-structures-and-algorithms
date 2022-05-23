using System;
using Xunit;
using Insertion_Sort;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] Reversesorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.InsertionSort(Reversesorted));
        }

        [Fact]
        public void Test2()
        {
            int[] Fewuniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.InsertionSort(Fewuniques));
        }

        [Fact]
        public void Test3()
        {
            int[] Nearlysorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.InsertionSort(Nearlysorted));
        }

        [Fact]
        public void Test4()
        {
            int[] Sample = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.InsertionSort(Sample));
        }

        [Fact]
        public void Test5()
        {
            int[] Sample = { 8, 4, 23, 42, 16, 15 };

            Assert.NotEqual(new int[] { 8, 4, 23, 42, 16, 15 }, Program.InsertionSort(Sample));
        }














    }
}
