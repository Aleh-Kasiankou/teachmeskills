namespace w3resource.Exercises.Function
{
    public class Exercise6: Exercise
    {
        public override string Description { get; } = " Write a program in C# Sharp to create a function to " +
                                                      "swap the values of two integer numbers.";

        public override void Run()
        {
            var userInts = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(userInts[0], userInts[1]));
        }

        public string Solve(int x, int y)
        {
            (x, y) = (y, x);
            return $"{x.ToString()}\n{y.ToString()}";
        }
    }
}