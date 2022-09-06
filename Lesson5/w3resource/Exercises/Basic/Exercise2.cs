namespace w3resource.Exercises.Basic
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print the sum of two numbers.";

        public override void Run()
        {
                        DisplayResult(Solve());
        }

        public string Solve() => $"2 + 5 = {(2+5).ToString()}";
    }
}