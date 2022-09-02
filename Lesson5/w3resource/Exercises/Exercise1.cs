using System;
using System.Collections.Generic;

namespace w3resource
{
    public class Exercise1 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to compute the sum of the two " +
            "given integer values. If the two values are the same, " +
            "then return triple their sum.";


        public override void Run()
        {
            DisplayDescription();
            List<int> operands = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));
        }

        public int Solve(int operand1, int operand2)
        {
            var result = operand1 != operand2 ? operand1 + operand2 : (operand1 + operand2) * 3;
            return result;
        }
    }
}