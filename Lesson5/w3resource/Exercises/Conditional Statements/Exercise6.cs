namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise6: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to read the value of an integer m " +
                                                      "and display the value of n is " +
                                                      "1 when m is larger than 0, " +
                                                      "0 when m is 0 and " +
                                                      "-1 when m is less than 0.";

        public override void Run()
        {
            DisplayDescription();
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public int Solve(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            if (x > 0)
            {
                return 1;
            }

            return -1;
        }
    }
}