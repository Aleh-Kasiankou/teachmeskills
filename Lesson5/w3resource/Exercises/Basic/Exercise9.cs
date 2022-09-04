using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.Basic
{
    public class Exercise9: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes four numbers as input " +
                                                      "to calculate and print the average.";

        public override void Run()
        {
            var operands = TerminalManager.GetDoubleOperands(4);
            DisplayResult(Solve(operands));
        }

        public string Solve(List<double> operands)
        {
            return $"Average: {operands.Average().ToString()}";
        }
    }
}