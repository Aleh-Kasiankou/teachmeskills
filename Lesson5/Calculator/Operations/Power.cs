using System;

namespace Calculator.Operations
{
    public class Power : Operation

    {
        public static string[] OperationSymbols = new[] { "pow", "^" };
    
        public override double Execute() => (double) Math.Pow((double) Operand1, (double) Operand2);

        public Power(double operand1, double operand2): base(operand1, operand2)
        {
        }
    }
}