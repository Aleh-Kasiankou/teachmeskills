namespace CalculatorApp.Operations
{
    public abstract class Operation: IOperation
    {
        public abstract double Operand1 { get; }
        public abstract double Operand2 { get; }
        public abstract double Execute();
        
    }
}