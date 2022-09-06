using System.Collections.Generic;

namespace w3resource.Exercises.Basic_Algorithm
{
    public class Exercise6 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to remove the character in a given position of a given string. " +
            "The given position will be in the range 0.. string length -1 inclusive.";


        public override void Run()
        {
            List<string> inputStrings = TerminalManager.GetStrings(1);
            List<int> inputInts = TerminalManager.GetIntOperands(1);
            DisplayResult(Solve(inputStrings[0], inputInts[0]));

        }
        
        public string Solve(string userString, int index)
        {
            var resultString = "Invalid index";
            if (index < userString.Length - 1)
            {

                resultString = userString.Remove(index, 1);
            }

            return resultString;
        }
    }
}