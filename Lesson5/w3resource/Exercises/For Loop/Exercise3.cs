namespace w3resource.Exercises.For_Loop
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display n terms of natural number " +
                                                      "and their sum.";

        public override void Run()
        {
            var n = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(n));
        }

        public string Solve(int n)
        {
            var naturalNumbersString = "";
            var naturalNumbersSum = 0;

            for (var i = 1; i <= n; i++)
            {
                naturalNumbersString += " " + i;
                naturalNumbersSum += i;
            }

            return $"First {n.ToString()} numbers: {naturalNumbersString}\n Their Sum: {naturalNumbersSum.ToString()}";
        }
    }
}