using System.Collections.Generic;

namespace w3resource.Exercises.Function
{
    public class Exercise8: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function to " +
                                                      "display the n number Fibonacci sequence.";

        public override void Run()
        {
            var fibonacciPosition = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(fibonacciPosition));
        }

        public string Solve(int fibonacciPosition)
        {
            var fibonacciNumbers = new List<int>();
            for (int i = 0; i < fibonacciPosition; i++)
            {
                if (fibonacciNumbers.Count < 1)
                {
                    fibonacciNumbers.Add(0);
                    continue;
                } else if (fibonacciNumbers.Count == 1)

                {
                    fibonacciNumbers.Add(1);
                    continue;
                }

                int prepreviousInt = fibonacciNumbers[i -= 2];
                    int previousInt = fibonacciNumbers[i -= 1];
                    fibonacciNumbers.Add(previousInt + prepreviousInt);
            }

            return System.String.Join(' ', fibonacciNumbers);
        }
    }
}