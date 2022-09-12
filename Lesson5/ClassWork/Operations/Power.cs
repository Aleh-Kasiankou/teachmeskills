using System;

namespace CalculatorApp.Operations
{
    public class Power : Operation

    {
        public static string[] OperationSymbols = new[] { "pow", "^" };
        public override double Operand1 { get; }
        public override double Operand2 { get; }

        public override double Execute() => (double) Math.Pow((double) Operand1, (double) Operand2);

        public Power(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }
    }
}