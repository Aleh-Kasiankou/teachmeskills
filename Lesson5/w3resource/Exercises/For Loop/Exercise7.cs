namespace w3resource.Exercises.For_Loop
{
    public class Exercise7: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display the multiplication table " +
                                                      "vertically from 1 to n.";

        public override void Run()
        {
            var userNumber = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(userNumber));
        }

        public string Solve(int userNumber)
        {
            var slaveExercise = new Exercise6();
            var multiplicationTableString = "";
            for (int i = 1; i <= userNumber; i++)
            {
                multiplicationTableString += slaveExercise.Solve(i) + "\n\n";
            }

            return multiplicationTableString;
        }
    }
}