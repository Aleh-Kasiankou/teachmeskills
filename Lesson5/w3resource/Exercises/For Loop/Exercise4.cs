using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.For_Loop
{
    public class Exercise4: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to read 10 numbers from keyboard " +
                                                      "and find their sum and average.";

        public override void Run()
        {
            var userNumbers = TerminalManager.GetDoubleOperands(10);
            DisplayResult(Solve(userNumbers));
        }

        public string Solve(List<double> userNumbers)
        {
            
            return $"AVG:{userNumbers.Average().ToString()}" +
                   $"\nSUM: {userNumbers.Sum().ToString()}";
        }
    }
}