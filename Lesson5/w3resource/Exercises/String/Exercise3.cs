namespace w3resource.Exercises.String
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to " +
                                                      "separate the individual characters from a string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var charsColumn = "";
            foreach (var character in userString)
            {
                charsColumn += $"{character.ToString()}\n";
            }

            return charsColumn;
        }
    }
}