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
    }
}
