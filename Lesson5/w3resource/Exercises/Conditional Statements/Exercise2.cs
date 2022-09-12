namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } =
            "Write a C# Sharp program to check whether a given number is even or odd.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(int x) => x % 2 == 0? "Even": "Odd";
    }
}