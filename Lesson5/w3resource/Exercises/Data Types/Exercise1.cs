using System.Collections.Generic;

namespace w3resource.Exercises.Data_Types
{
    public class Exercise1: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes three letters as input " +
                                                      "and display them in reverse order.";

        public override void Run()
        {
            DisplayDescription();
            var charsList = TerminalManager.GetChars(3);
            DisplayResult(Solve(charsList));
        }

        public string Solve(List<char> charsList)
        {
            var reversedChars = System.String.Concat(charsList);
            return reversedChars;
        }
    }
}