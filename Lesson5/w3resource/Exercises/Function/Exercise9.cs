using System;

namespace w3resource.Exercises.Function
{
    public class Exercise9: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a function to check " +
                                                      "whether a number is prime or not.";

        public override void Run()
        {
            DisplayDescription();
            var userInt = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(userInt));
        }

        public bool Solve(int userInt)
        {
            var userIntRoot = Math.Sqrt(userInt);
            var isComposite = false;
            for (var i = 2; i <= userIntRoot; i++)
            {
                if (userInt % i == 0 && userIntRoot != 0)
                {
                    isComposite = true;
                }
            }

            return !isComposite;
        }
    }
}