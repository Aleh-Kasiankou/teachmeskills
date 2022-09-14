namespace Calculator.Operations
{
    public class Percentage: Operation
    {
        public static string[] OperationSymbols = new[] { "%" };
        public override double Execute() => Operand1 / 100 * Operand2;

        public Percentage(double operand1, double operand2): base(operand1, operand2)
        {
        }
    
    }
}