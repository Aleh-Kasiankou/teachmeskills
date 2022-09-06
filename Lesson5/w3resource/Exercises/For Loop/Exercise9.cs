namespace w3resource.Exercises.For_Loop

{
    public class Exercise9: Exercise
    {
        public override string Description { get; } =
            "Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.";
        public override void Run()
        {
            var rows = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve("*", rows));
        }

        public string Solve(string userIntChar, int rows)
        {
            var slaveWorker = new w3resource.Exercises.Data_Types.Exercise2();
            return slaveWorker.Solve(userIntChar, rows);
        }
    }
}