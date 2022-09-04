namespace w3resource.Exercises.Basic
{
    public class Exercise6: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print the output of " +
                                                      "multiplication of three numbers " +
                                                      "which will be entered by the user.";

        public override void Run()
        {
            DisplayDescription();
            var operands = TerminalManager.GetDoubleOperands(3);
            DisplayResult(Solve(operands[0], operands[1], operands[2]));
        }

        public double Solve(double operand1, double operand2, double operand3) => operand1 * operand2 * operand3;
    }
}