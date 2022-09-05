namespace w3resource.Exercises.String
{
    public class Exercise1: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to input a string and print it.";

        public override void Run()
        {
            DisplayDescription();
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString) => $"You wrote:\n{userString}";
    }
}