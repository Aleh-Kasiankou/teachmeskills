namespace Calculator.Operations
{
    public class Multiplication : Operation
    {
        public static string[] OperationSymbols = new[] { "*", "x" };
        public override double Execute() => Operand1 * Operand2;

        public Multiplication(double operand1, double operand2): base(operand1, operand2)
        {
        }
    }
}