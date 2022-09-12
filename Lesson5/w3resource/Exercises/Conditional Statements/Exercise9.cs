namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise9 : Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to accept a coordinate point in an " +
                                                      "XY coordinate system and determine in " +
                                                      "which quadrant the coordinate point lies.";

        public override void Run()
        {
            var operands = TerminalManager.GetDoubleOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));
        }

        public string Solve(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return "I";
            }

            if (x > 0 && y < 0)
            {
                return "II";
            }

            if (x < 0 && y < 0)
            {
                return "III";
            }

            if (x < 0 && y > 0)
            {
                return "IV";
            }

            return "On Coordinate Plane";
        }
    }
}