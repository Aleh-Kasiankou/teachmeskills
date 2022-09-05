namespace w3resource.Exercises.String
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to find the length of a string " +
                                                      "without using library function.";

        public override void Run()
        {
            DisplayDescription();
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var charCount = 0;
            foreach (var character in userString)
            {
                charCount += 1;
            }

            return $"Length is {charCount.ToString()} chars";
        }
    }
}