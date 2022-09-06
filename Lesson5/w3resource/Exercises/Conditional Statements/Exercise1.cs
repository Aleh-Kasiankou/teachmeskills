namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise1 : Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to accept two integers and " +
                                                      "check whether they are equal or not.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));
        }

        public bool Solve(int x, int y) => x == y;
    }
}