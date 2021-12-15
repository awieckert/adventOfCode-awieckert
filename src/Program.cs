using System;

namespace adventOfCode_awieckert
{
    class Program
    {
        static void Main(string[] args)
        {
            var question1 = new Question1();

            var solution1 = question1.SolveThatShit();

            Console.WriteLine($"************ SOLUTION #1a ************");
            Console.WriteLine($"There are: {solution1} increasing numbers");

            var solution1b = question1.SolveThatShitAgain();

            Console.WriteLine($"************ SOLUTION #1b ************");
            Console.WriteLine($"There are: {solution1b} increasing numbers");
        }
    }
}
