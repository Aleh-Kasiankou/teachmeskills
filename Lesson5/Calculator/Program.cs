using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsContinue = false;
            bool isWorkWithMemory = false;

            do
            {
                try
                {
                    string expression;
                    int id = -1;

                    expression = isWorkWithMemory
                        ? TerminalManager.UpdateExpressionFromMemory(out id)
                        : TerminalManager.GetExpression();

                    if (string.IsNullOrWhiteSpace(expression) && isWorkWithMemory)
                    {
                        continue;
                    }

                    var total = Calculator.Calculate(expression);
                    Calculator.MemorizeOperation(expression.Trim('='), total, id);
                    TerminalManager.DisplayResult(expression, total);
                }
                catch (Exception e)
                {
                    TerminalManager.DisplayException(e);
                }
                finally
                {
                    TerminalManager.AskIsContinue(ref IsContinue, ref isWorkWithMemory);
                }
            } while (IsContinue);
        }
    }
}