namespace w3resource.Exercises.String
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to " +
                                                      "count the total number of words in a string.";

        public override void Run()
        {
            DisplayDescription();
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public int Solve(string userString) => userString.Split().Length;
    }
}