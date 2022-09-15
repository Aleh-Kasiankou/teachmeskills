using System;
using System.Linq;

namespace w3resource.Exercises.Function
{
    public class Exercise10 : Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function to calculate " +
                                                      "the sum of the individual digits of a given number";

        public override void Run()
        {
            var userOperand = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(Math.Abs(userOperand)));
        }

        public string Solve(int userOperand)
        {
            var digits = userOperand.ToString().Select(x => x);
            var digitsInt = digits.Select(x => Int32.Parse(x.ToString()));
            return $"Sum is {digitsInt.Sum().ToString()}";
        }
    }
}