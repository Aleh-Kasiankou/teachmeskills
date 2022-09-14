namespace Calculator.Operations
{
    public class Division : Operation
    {
        public static string[] OperationSymbols = new[] { "/" };
        public override double Execute() => Operand1 / Operand2;

        public Division(double operand1, double operand2) : base(operand1, operand2)
        {
        }
    }
}