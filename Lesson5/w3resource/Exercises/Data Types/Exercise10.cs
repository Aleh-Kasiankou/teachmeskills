namespace w3resource.Exercises.Data_Types
{
    public class Exercise10: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes two numbers as input " +
                                                      "and returns true or false when both numbers are even or odd.";

        public override void Run()
        {
            var operandsList = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(operandsList[0], operandsList[1]));
        }

        public bool Solve(int operand1, int operand2)
        {
            var isTwoOperandsEven = operand1 % 2 == 0 && operand2 % 2 == 0;
            var isTwoOperandsOdd = operand1 % 2 != 0 && operand2 % 2 != 0;
            return isTwoOperandsEven || isTwoOperandsOdd;
        }
    }
    }