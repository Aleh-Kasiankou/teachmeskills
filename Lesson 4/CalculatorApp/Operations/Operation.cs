namespace CalculatorApp.Operations
{
    public abstract class Operation: IOperation
    {
        public abstract decimal Operand1 { get; }
        public abstract decimal Operand2 { get; }
        public abstract decimal Execute();
    }
}