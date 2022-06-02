using System;
using Xunit;
using static Merge_Sort.Program;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestReversesorted()
        {
            int[] Reversesorted = { 20, 18, 12, 8, 5, -2 };
            int[] result = { -2, 5, 8, 12, 18, 20 };



            Assert.Equal(result, MergeSort(Reversesorted));
        }

        [Fact]
        public void TestFewuniques()
        {
            int[] Fewuniques = { 5, 12, 7, 5, 5, 7 };
            int[] result = { 5, 5, 5, 7, 7, 12 };



            Assert.Equal(result, MergeSort(Fewuniques));
        }

        [Fact]
        public void TestNearlysorted()
        {
            int[] x = { 2, 3, 5, 7, 13, 11 };
            int[] result = { 2, 3, 5, 7, 11, 13 };



            Assert.Equal(result, MergeSort(x));
        }
    }
}
