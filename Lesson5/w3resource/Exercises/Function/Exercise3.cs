namespace w3resource.Exercises.Function
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function " +
                                                      "for the sum of two numbers.";

        public override void Run()
        {
            DisplayDescription();
            var userOperands = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(userOperands[0], userOperands[1]));
        }

        public string Solve(int x, int y) => $"{x.ToString()} + {y.ToString()} = {(x+y).ToString()}";
    }
}