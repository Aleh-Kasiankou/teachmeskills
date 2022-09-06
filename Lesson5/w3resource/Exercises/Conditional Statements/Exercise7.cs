namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise7: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to " +
                                                      "accept the height of a person in centimeter and " +
                                                      "categorize the person according to their height.";

        public override void Run()
        {
            var operands = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(operands[0]));
        }

        public string Solve(int height)
        {
            if (height <= 0)
            {
                return "Nice Try";
            }

            if (height > 200)
            {
                return "Undertaker";
            } else if (height > 180)
            {
                return "Big Boy";
            } else if (height == 174)
            {
                return "Daddy";
            } else if (height > 170 )
            {
                return "You are still growing";
            }

            else
            {
                return $"Hey fellow,you should avoid sweet elderly people with thick moustache";
            }
        }
    }
}