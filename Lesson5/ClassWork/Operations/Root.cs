using System;

namespace CalculatorApp.Operations
{
    public class Root: Operation
    {
        public static string[] OperationSymbols = new[] { "root" };
        public override double Operand1 { get; }
        public override double Operand2 { get; }

        public override double Execute() => (double) Math.Pow((double) Operand1, (double) (1/Operand2));

        public Root(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }
    }
}