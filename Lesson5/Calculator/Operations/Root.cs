using System;

namespace Calculator.Operations
{
    public class Root: Operation
    {
        public static string[] OperationSymbols = new[] { "root" };
      
        public override double Execute() => (double) Math.Pow((double) Operand1, (double) (1/Operand2));

        public Root(double operand1, double operand2): base(operand1, operand2)
        {
        }
    }
}