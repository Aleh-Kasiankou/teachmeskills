namespace w3resource.Exercises.Basic
{
    public class Exercise8: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes a number as input " +
                                                      "and print its multiplication table.";

        public override void Run()
        {
            var operands = TerminalManager.GetDoubleOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(double operand1)
        {
            string multiplicationTable = "";
            for (int i = 1; i <= 10; i++)
            {
                multiplicationTable += $"{operand1.ToString()} * {i.ToString()} = { (operand1 * i).ToString()}\n";
            }

            return multiplicationTable;
        }
    }
}