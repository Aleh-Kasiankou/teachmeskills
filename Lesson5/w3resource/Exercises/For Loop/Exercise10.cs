namespace w3resource.Exercises.For_Loop
{
    public class Exercise10: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display the pattern like " +
                                                      "right angle triangle with a number.";

        public override void Run()
        {
            DisplayDescription();
            var userInput = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(userInput[0].ToString(), userInput[1]));
        }

        public string Solve(string userIntChar, int rows)
        {
            var slaveWorker = new w3resource.Exercises.Data_Types.Exercise2();
            return slaveWorker.Solve(userIntChar, rows);
        }
    }
}