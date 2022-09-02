using System.Collections.Generic;

namespace w3resource.Exercises
{
    public class Exercise3 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to check two given integers, and return true if one of them is 30" +
            " or if their sum is 30";


        public override void Run()
        {
            DisplayDescription();
            List<int> operands = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));

        }

        
        public bool Solve(int operand1, int operand2)
        {
            var is30 = operand1 == 30 || operand2 == 30; // Ambiguous description. Could use ^ or |
            var isSum30 = operand1 + operand2 == 30;
            
            return (is30 || isSum30);
        }
    }
}