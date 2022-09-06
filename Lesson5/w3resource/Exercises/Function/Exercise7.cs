using System;

namespace w3resource.Exercises.Function
{
    public class Exercise7: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function to " +
                                                      "calculate the result of raising an integer number to another.";

        public override void Run()
        {
            var userOperands = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(userOperands[0], userOperands[1]));
        }

        public string Solve(int x, int exponent) => $"{x.ToString()} ^ {exponent.ToString()} =" +
                                                    $" {Math.Pow(x, exponent).ToString()}";
    }
}