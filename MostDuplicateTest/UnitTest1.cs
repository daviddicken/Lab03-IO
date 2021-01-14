using System;
using Xunit;
using Lab03_IO;

namespace MostDuplicateTest
{
    public class UnitTest1
    {
        [Fact]
        public void NoDoubles()
        {
            int[] testArr = new int[] { 2, 20, 30, 31, 33, 12, 13 };
            Assert.Equal(2, Program.MostDuplicates(testArr));
        }

        public void DoubleDoubles()
        {
            int[] testArr = new int[] { 2, 2, 30, 31, 33, 1, 1 };
            Assert.Equal(2, Program.MostDuplicates(testArr));
        }

        public void AllSame()
        {
            int[] testArr = new int[] { 2, 2, 2 };
            Assert.Equal(2, Program.MostDuplicates(testArr));
        }

        public void OneIndex()
        {
            int[] testArr = new int[] { 2 };
            Assert.Equal(2, Program.MostDuplicates(testArr));
        }


    }
}
