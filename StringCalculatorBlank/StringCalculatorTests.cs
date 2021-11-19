using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringCalculatorBlank
{
    // https://osherove.com/tdd-kata-1
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            var calculator = new StringCalculator();

            int answer = calculator.Add("");

            Assert.Equal(0, answer);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void OneNum(string numbers, int expected)
        {
            var sDigit = new StringCalculator();

            int answer = sDigit.Add(numbers);

            Assert.Equal(expected, answer); 
        }

        [Theory]
        [InlineData("1,1", 2)]
        [InlineData("2,2", 4)]
        public void TwoNum(string numbers, int expected)
        {
            var dDigit = new StringCalculator();

            int answer = dDigit.Add(numbers);

            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("1,1,1", 3)]
        [InlineData("2,2,2,2", 8)]
        public void MultipleNums(string numbers, int expected)
        {
            var dDigit = new StringCalculator();

            int answer = dDigit.Add(numbers);

            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("1,\n1,1", 3)]
        [InlineData("2,2,2,\n2", 8)]
        public void newLineNums(string numbers, int expected)
        {
            var dDigit = new StringCalculator();

            int answer = dDigit.Add(numbers);

            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("1,\n1,1", 3)]
        [InlineData("2,2,2,\n2", 8)]
        public void delimeterNums(string numbers, int expected)
        {
            var dDigit = new StringCalculator();

            int answer = dDigit.Add(numbers);

            Assert.Equal(expected, answer);
        }
    }
}
