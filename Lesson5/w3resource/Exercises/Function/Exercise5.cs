using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.Function
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to calculate " +
                                                      "the sum of elements in an array.";

        public override void Run()
        {
            var userInts = TerminalManager.GetIntOperands(5);
            DisplayResult(Solve(userInts));
        }

        public string Solve(List<int> userInts) => $"AVG = {userInts.Average().ToString()}";
    }
}