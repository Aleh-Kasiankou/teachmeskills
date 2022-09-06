namespace w3resource.Exercises.Basic
{
    public class Exercise1: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print Hello and your name" +
                                                      " in a separate line.";

        public override void Run()
        {
                        DisplayResult(Solve());
        }

        public string Solve() => $"Hello\nAleh Kasiankou";
    }
}