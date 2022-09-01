using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsContinue = false;
            do
            {
                try
                {
                    IsContinue = false;
                    double operand1 = TerminalManager.GetOperand();
                    string operation = TerminalManager.GetOperation();
                    double operand2 = TerminalManager.GetOperand();
                    Calculator calculator = new Calculator(operand1, operand2, operation);
                    TerminalManager.DisplayResult(calculator.Execute());
                }
                catch (Exception e)
                {
                    TerminalManager.DisplayException(e);
                }
                
                TerminalManager.AskIsContinue(ref IsContinue);

            } while (IsContinue);

        }
    }
}