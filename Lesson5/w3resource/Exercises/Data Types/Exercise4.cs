namespace w3resource.Exercises.Data_Types
{
    public class Exercise4 : Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes two numbers as input " +
                                                      "and perform an operation (+,-,*,x,/) on them " +
                                                      "and displays the result of that operation.";

        public override void Run()
        {
            var operandsList = TerminalManager.GetDoubleOperands(2);
            var operation = TerminalManager.GetChars(1);
            DisplayResult(Solve(operandsList[0], operandsList[1], operation[0]));
        }

        public string Solve(double x, double y, char operation)
        {
            switch (operation)
            {
                case '+':
                    return $"{x.ToString()} + {y.ToString()} = {(x + y).ToString()}";
                case '-':
                    return $"{x.ToString()} - {y.ToString()} = {(x - y).ToString()}";
                case '*':
                case 'X':
                    return $"{x.ToString()} * {y.ToString()} = {(x * y).ToString()}";
                case '/':
                    return y != 0
                        ? $"{x.ToString()} / {y.ToString()} = {(x / y).ToString()}"
                        : "Division by zero is not allowed";
                default:
                    return $"The operation is not supported";
            }
        }
    }
}