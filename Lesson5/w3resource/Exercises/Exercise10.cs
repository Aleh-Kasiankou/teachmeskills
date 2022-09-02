using System.Collections.Generic;

namespace w3resource.Exercises
{
    public class Exercise10 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7";


        public override void Run()
        {
            DisplayDescription();
            List<int> operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public bool Solve(int operand)
        {
            return operand % 7 == 0 || operand % 3 == 0;
        }
    }
}