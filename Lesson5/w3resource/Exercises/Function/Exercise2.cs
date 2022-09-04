namespace w3resource.Exercises.Function
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a user define function " +
                                                      "with parameters.";

        public override void Run()
        {
            DisplayDescription();
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString) => $"I am dummy function with parameters! You wrote:\n{userString}";
    }
}