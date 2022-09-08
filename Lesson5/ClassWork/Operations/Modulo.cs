namespace CalculatorApp.Operations
{
    public class Modulo: Operation
    {
        public static string[] OperationSymbols = new[] { "mod" };
        public override double Operand1 { get; }
        public override double Operand2 { get; }

        public override double Execute() => Operand1 % Operand2;

        public Modulo(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }
    
    }
}