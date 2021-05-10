using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        private const int FizzValue = 3;
        private const int BuzzValue = 5;
        private const string FizzMessage = "Fizz";
        private const string BuzzMessage = "Buzz";

        public string Convert(int number)
        {
            if (number < 1)
                throw new ArgumentException($"Argument {nameof(number)} cannot be {number}");

            string output = string.Empty;
            if (number % FizzValue == 0)
                output += FizzMessage;
            if (number % BuzzValue == 0)
                output += BuzzMessage;
            if (output == string.Empty)
                output += number.ToString();
            return output;
        }
    }
}
