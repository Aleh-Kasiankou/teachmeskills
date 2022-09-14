namespace Calculator.Operations
{
    public class Modulo: Operation
    {
        public static string[] OperationSymbols = new[] { "mod" };
        public override double Execute() => Operand1 % Operand2;

        public Modulo(double operand1, double operand2): base(operand1, operand2)
        {
        }
    
    }
}