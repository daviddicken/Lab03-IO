using System;
using Xunit;
using Lab03_IO;

namespace ProductOfThreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath()
        {
            Assert.Equal(24, Program.ProductOfThree("1 12 2"));
        }

        public void tooMuch()
        {
            Assert.Equal(24, Program.ProductOfThree("1 12 2 4"));
        }
    }
}
