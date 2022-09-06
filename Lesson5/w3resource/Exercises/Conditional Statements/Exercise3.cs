namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to check whether a given number is " +
                                                      "positive or negative.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(int x)
        {
            if (x == 0)
            {
                return "Zero";
            }

            if (x > 0)
            {
                return "Positive";
            }

            return "Negative";
        }
    }
}