namespace w3resource.Exercises.String
{
    public class Exercise8 : Exercise
    {
        public override string Description { get; } =
            "Write a program in C# Sharp to copy one string to another string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var newString = System.String.Copy(userString);
            return $"Copied String:\n{newString}";
        }
    }
}