using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise8: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to find the largest of three numbers.";

        public override void Run()
        {
            DisplayDescription();
            var operands = TerminalManager.GetDoubleOperands(3);
            DisplayResult(Solve(operands));
        }

        public double Solve(List<double> numbers) => numbers.Max();
    }
}