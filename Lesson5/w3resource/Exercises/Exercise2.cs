using System;
using System.Collections.Generic;

namespace w3resource
{
    public class Exercise2 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to get the absolute difference between n" +
            " and 51. If n is greater than 51 return triple the absolute difference.";


        public override void Run()
        {
            DisplayDescription();
            List<int> operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));

        }

        public int Solve(int operand1)
        {
            var result = operand1 > 51 ? 51 - operand1 * 3 : 51 - operand1;
            return result;
        }
    }
}