namespace w3resource.Exercises.Basic
{
    public class Exercise10: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to that takes three numbers(x,y,z) as input " +
                                                      "and print the output of (x+y)*z and x*y + y*z.";

        public override void Run()
        {
            var operands = TerminalManager.GetDoubleOperands(3);
            DisplayResult(Solve(operands[0], operands[1], operands[2]));
        }

        public string Solve(double operand1, double operand2, double operand3)
        {
            double bracketsExpression = (operand1 + operand2) * operand3;
            double noBracketsExpression = operand1 * operand2 + operand2 * operand3;
            
            string output = $"({operand1.ToString()} + {operand2.ToString()}) *" +
                            $" {operand3.ToString()} =" +
                            $" {bracketsExpression.ToString()}";
            
            output += $"\n({operand1.ToString()} * {operand2.ToString()}) +" +
                      $" {operand2.ToString()} * {operand3.ToString()} =" +
                      $" {noBracketsExpression.ToString()}";

            return output;
        }
    }
}