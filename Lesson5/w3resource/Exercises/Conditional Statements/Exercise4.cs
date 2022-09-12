namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise4: Exercise
    {
        public override string Description { get; } =
            "Write a C# Sharp program to find whether a given year is a leap year or not.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(int year)
        {
            string yearType;
            if (year % 4 != 0)
            {
                yearType = "Common";
            }
            else if (year % 100 != 0)
            {
                yearType = "Leap";
            }
            else if (year % 400 != 0)
            {
                yearType = "Common";
            }
            else
            {
                yearType = "Leap";
            }

            return yearType;
        }
    }
}