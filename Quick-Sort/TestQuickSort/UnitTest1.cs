using System;
using Xunit;
using Quick_Sort;
using static Quick_Sort.Program;

namespace TestQuickSort
{
    public class UnitTest1
    {
        

        [Fact]
        public void TestReversesorted()
        {
            int[] Reversesorted = { 20, 18, 12, 8, 5, -2 };
            int[] result = { -2, 5, 8, 12, 18, 20 };



            Assert.Equal(result, QuickSort(Reversesorted, 0, Reversesorted.Length - 1));
        }

        [Fact]
        public void TestFewuniques()
        {
            int[] Fewuniques = { 5, 12, 7, 5, 5, 7 };
            int[] result = { 5, 5, 5, 7, 7, 12 };



            Assert.Equal(result, QuickSort(Fewuniques, 0, Fewuniques.Length - 1));
        }

        [Fact]
        public void TestNearlysorted()
        {
            int[] x = { 2, 3, 5, 7, 13, 11 };
            int[] result = { 2, 3, 5, 7, 11, 13 };



            Assert.Equal(result, QuickSort(x, 0, x.Length - 1));
        }














    }
}
