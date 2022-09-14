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
                    if (!isWorkWithMemory)
                    {
                        var expression = TerminalManager.GetExpression();
                        var total = Calculator.Calculate(expression);
                        Calculator.MemorizeOperation(expression.Trim('='), total);
                        Console.WriteLine(expression + " = " + total);
                    }

                    else
                    {
                        var expression = TerminalManager.UpdateExpressionFromMemory(out var id);
                        if (string.IsNullOrWhiteSpace(expression))
                        {
                            continue;
                        }

                        var total = Calculator.Calculate(expression);
                        Calculator.MemorizeOperation(expression.Trim('='), total, id);
                        Console.WriteLine(expression + " = " + total);
                    }
                }
                catch (Exception e)
                {
                    TerminalManager.DisplayException(e);
                }
                finally{TerminalManager.AskIsContinue(ref IsContinue, ref isWorkWithMemory);}
            } while (IsContinue);
        }
    }
}