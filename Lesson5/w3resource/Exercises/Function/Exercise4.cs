using System.Linq;

namespace w3resource.Exercises.Function
{
    public class Exercise4: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function to " +
                                                      "input a string and count number of spaces are in the string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString) => $"I found {userString.Count(x => x == ' ').ToString()} spaces";
    }
}