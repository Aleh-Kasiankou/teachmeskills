namespace w3resource.Exercises.Data_Types
{
    public class Exercise6: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to display " +
                                                      "certain values of the function x = y2 + 2y + 1 " +
                                                      "(using integer numbers for y , ranging from -5 to +5)";

        public override void Run()
        {
            DisplayResult(Solve());
        }

        public string Solve()
        {
            var solvedFuncations = "";
            for (var i = -5; i <= 5; i++)
            {
                 
                solvedFuncations += $"{i.ToString()} * 2 + 2 * {i.ToString()} + 1 = {(i * 2 + 2 * i + 1).ToString()}\n";
            }

            return solvedFuncations;
        }
    }
}