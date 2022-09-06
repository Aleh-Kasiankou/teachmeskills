using System;

namespace w3resource.Exercises.For_Loop
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display the cube of the number up " +
                                                      "to given an integer.";

        public override void Run()
        {
            var userNumber = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(userNumber));
        }

        public string Solve(int userNumber)
        {
            var CubesString = "";
            for (int i = 1; i <= userNumber; i++)
            {
                CubesString += Math.Pow(i, 3) +" ";
            }

            return CubesString;
        }
    }
}