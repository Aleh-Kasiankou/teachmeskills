using System;

namespace CalculatorApp
{
    public class TerminalHandler
    {
        internal double Operand1;
        internal double Operand2;

        public bool Operand1Assigned = false;
        public bool Operand2Assigned = false;

        internal string Operation { get; private set; }
        private string OperandToSet => (!Operand1Assigned) ? "first" : "second";

        private string _operandPrompt => $"Please, type your {OperandToSet} operand";

        private string _operationPrompt = "Please, type your operation. Currently available operations:\n" +
                                          "+, -,*, /, mod, pow, %, root";


        public void SetOperands()
        {
            while (!Operand1Assigned || !Operand2Assigned)
            {
                try
                {
                    if (!Operand1Assigned)
                    {
                        Console.WriteLine(_operandPrompt);
                        Operand1 = double.Parse(Console.ReadLine());
                        Operand1Assigned = true;
                    }

                    if (!Operand2Assigned)
                    {
                        Console.WriteLine(_operandPrompt);
                        Operand2 = double.Parse(Console.ReadLine());
                        Operand2Assigned = true;
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public void SetOperation()
        {
            Console.WriteLine(_operationPrompt);
            Operation = Console.ReadLine();
        }

        public void PromptContinue(ref bool isContinue)
        {
            Console.WriteLine("Conduct another operation?");
            isContinue = Console.ReadLine().ToLower() == "yes";
        }
    }
}