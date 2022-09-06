namespace w3resource.Exercises.Basic
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print the result " +
                                                      "of dividing two numbers.";

        public override void Run()
        {
                        DisplayResult(Solve());
        }

        public string Solve() => $"2 - 5 = {(2-5).ToString()}";
    }
}