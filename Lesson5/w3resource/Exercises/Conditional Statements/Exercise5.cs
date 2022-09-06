namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to read the age of a candidate and " +
                                                      "determine whether it is eligible for casting his/her own vote.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(int age) => age > 18 ? "Eligible" : "Too young";
    }
}