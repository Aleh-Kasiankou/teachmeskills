namespace CalculatorApp.Operations
{
    public class Subtraction : Operation
    {
        public override decimal Operand1 { get; }
        public override decimal Operand2 { get; }
        
        public override decimal Execute() => Operand1 - Operand2;

        public Subtraction(decimal operand1, decimal operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }
    }
}