using System.Linq;

namespace w3resource.Exercises.String
{
    public class Exercise4: Exercise
    {
        public override string Description { get; } =
            "Write a program in C# Sharp to print individual characters of the string in reverse order.";

        public override void Run()
        {
            DisplayDescription();
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var charsColumn = "";
            var reversedString = userString.Reverse();
            foreach (var character in reversedString)
            {
                charsColumn += $"{character.ToString()}\n";
            }

            return charsColumn;
        }
    }
}