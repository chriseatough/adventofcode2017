using System;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class AdventOfCode2017Tests
    {
        [Theory(DisplayName = "InverseCaptcha")]
        [InlineData("1122", "3")]
        [InlineData("1111", "4")]
        [InlineData("1234", "0")]
        [InlineData("91212129", "9")]
        public void TestInverseCaptcha(string input, string @is)
        {
            Assert.Equal(@is, AdventOfCode2017.AdventOfCode2017.InverseCaptcha(input));
        }
    }
}
