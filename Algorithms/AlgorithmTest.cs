using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
        }

        [Theory]
        [InlineData(new string[] { }, "")]
        [InlineData(new[] { "a" }, "a")]
        [InlineData(new[] { "a", "b" }, "a and b")]
        [InlineData(new[] { "a", "b", "c" }, "a, b and c")]
        public void CanFormatSeparators(string[] input, string expected)
        {
            Assert.Equal(expected, Algorithms.FormatSeparators(input));
        }
    }
}