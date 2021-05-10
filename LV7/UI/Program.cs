using System;
using FizzBuzz;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            for (int i = start; i <= end; i++)
            {
                FizzBuzzer fizzBuzzer = new FizzBuzzer();
                string message = fizzBuzzer.Convert(i);
                System.Console.WriteLine(message);
            }
        }
    }
}
