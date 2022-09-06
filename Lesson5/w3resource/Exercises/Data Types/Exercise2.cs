using System.Linq;

namespace w3resource.Exercises.Data_Types
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes " +
                                                      "a number and a width also a number, as input " +
                                                      "and then displays a triangle of that width, using that number.";

        public override void Run()
        {
            var userInput = TerminalManager.GetIntOperands(2);
            DisplayResult(Solve(userInput[0].ToString(), userInput[1]));
        }

        public string Solve(string userIntChar, int width)
        {
            var stringTriangle = "";
            for (int i = 1; i <= width; i++)
            {
                stringTriangle += System.String.Concat(Enumerable.Repeat(userIntChar, i)) + "\n";
            }

            return stringTriangle;
        }
    }
}