namespace Calculator.Operations
{
    public abstract class Operation
    {
        protected double Operand1 { get; }
        protected double Operand2 { get; }
        public abstract double Execute();

        protected Operation(double operand1, double operand2)
        {
            Operand1 = operand1;

            Operand2 = operand2;
        }


    }
}