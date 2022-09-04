namespace w3resource.Exercises.Basic
{
    public class Exercise7: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print on screen the output of " +
                                                      "adding, " +
                                                      "subtracting, " +
                                                      "multiplying " +
                                                      "and dividing " +
                                                      "of two numbers which will be entered by the user.";

        public override void Run()
        {
            var operands = TerminalManager.GetDoubleOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));
        }

        public string Solve(double operand1, double operand2)
        {
            string divisionByZeroMsg = "Sorry, division by zero is forbidden";
            
            string output = $"adding: {(operand1 + operand2).ToString()}" +
                            $"\nsubtracting: {(operand1 - operand2).ToString()}" +
                            $"\nmultiplying: {(operand1 * operand2).ToString()}" +
                             "\ndividing: " +
                            $"{((operand1 != 0) ? (operand1 / operand2).ToString() : divisionByZeroMsg)}";

            return output;
        }
    }
}