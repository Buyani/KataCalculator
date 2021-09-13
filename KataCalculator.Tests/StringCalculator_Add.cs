using System;
using Xunit;

namespace KataCalculator.Tests
{
    public class StringCalculator_Add
    {
        private StringKataCalculator calculator = new StringKataCalculator();
        [Theory]
        [InlineData("",0)]
        [InlineData(" ",0)]
        public void Returns_Zero_Given_EmptyString_Or_EmptySpace(string inputstring,int expected)
        {
            var results = calculator.Add(inputstring);
            Assert.Equal(expected, results);
        }
        [Theory]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        public void Returns_Sum_Given_NumbersSepearted_By_Comma(string inputstring, int expected)
        {
            var results = calculator.Add(inputstring);
            Assert.Equal(expected, results);
        }
        [Theory]
        [InlineData("1\n2,3", 6)]
        public void Returns_Sum_Given_NumbersSepearted_By_Comma_And_NewLine(string inputstring, int expected)
        {
            var results = calculator.Add(inputstring);
            Assert.Equal(expected, results);
        }
    }
}
