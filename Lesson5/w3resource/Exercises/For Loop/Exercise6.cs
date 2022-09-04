namespace w3resource.Exercises.For_Loop
{
    public class Exercise6 : Exercise
    {
        public override string Description { get; } =
            "Write a program in C# Sharp to display the multiplication table " +
            "of a given integer.";

        public override void Run()
        {
            DisplayDescription();
            var userNumber = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(userNumber));
        }

        public string Solve(int userNumber)
        {
            var multiplicationTableString = "";
            for (int i = 1; i <= 10; i++)
            {
                multiplicationTableString += $"{userNumber.ToString()} * {i.ToString()} " +
                                        $"= {(i * userNumber).ToString()}\n";
            }

            return multiplicationTableString;
        }
    }
}