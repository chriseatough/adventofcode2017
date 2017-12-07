using System;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class AdventOfCode2017Tests
    {
        [Theory(DisplayName = "InverseCaptcha")]
        [InlineData(new int[] { 1, 1, 2, 2 }, 3)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 0)]
        [InlineData(new int[] { 9, 1, 2, 1, 2, 1, 2, 9 }, 9)]
        public void TestInverseCaptcha(int[] input, int expected)
        {
            Assert.Equal(expected, AdventOfCode2017.AdventOfCode2017.InverseCaptcha(input));
        }
    }
}
