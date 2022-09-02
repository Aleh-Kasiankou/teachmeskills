using System.Collections.Generic;

namespace w3resource.Exercises
{
    public class Exercise4: Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.";


        public override void Run()
        {
            DisplayDescription();
            List<int> operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));

        }
        
        public bool Solve(int operand1)
        {
            return Within10of100or200(operand1);
        }
        
        public bool Within10of100or200(int operand)
        {
            return operand >= 90 && operand <= 110 || operand >= 110 && operand <= 210;
        }
    }
}