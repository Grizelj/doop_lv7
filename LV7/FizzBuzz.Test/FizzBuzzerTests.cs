using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Test 
{
    [TestFixture]
    class FizzBuzzerTests
    {
        private static int[] IndivisibleInput = new int[] { 1, 2, 3, 4, 7, 8, 11, 13 };
        [TestCaseSource(nameof(IndivisibleInput))]
        public void Convert_WhenInputIsIndivisible_ReturnsNumberAsString(int number) {
            // Arrange
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            string expected = number.ToString();

            // Act
            string actual = fizzBuzzer.Convert(number);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Convert_WhenInputIsDivisibleByFizz_ReturnsFizz(int number) {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "Fizz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Convert_WhenInputIsDivisibleByBuzz_ReturnsBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "Buzz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Convert_WhenInputIsDivisibleByFizzAndBuzz_ReturnsFizzBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "FizzBuzz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }
        public void Convert_WhenInputIsZeroOrNegative_ThrowsArgumentException()
        {
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            int number = 0;
            Assert.Throws<ArgumentException>(() => FizzBuzzer.Convert(number)) ;
        }
    }
}
