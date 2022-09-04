namespace w3resource.Exercises.Basic
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to swap two numbers";

        public override void Run()
        {
            DisplayDescription();
            DisplayResult(Solve(23, 18));
        }

        public string Solve(double x, double y)
        {
            string output = $"Before swapping: \nx:{x.ToString()} \ny:{y.ToString()}";
            (x, y) = (y, x);
            output += $"\n\nAfter Swapping: \nx:{x.ToString()} \ny:{y.ToString()}";

            return output;
        }
    }
}