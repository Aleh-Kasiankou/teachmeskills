using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.Basic_Algorithm
{
    public class Exercise8 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. " +
            "If the given string length is less than 2 return the original string.";


        public override void Run()
        {
            DisplayDescription();
            List<string> inputStrings = TerminalManager.GetStrings(1);
            DisplayResult(Solve(inputStrings[0]));

        }
        
        public string Solve(string userString)
        {
            var returnString = userString;
            if (userString.Length > 1)
            {
                var firstTwoLetters = userString.Substring(0, 2);
                returnString = System.String.Concat(Enumerable.Repeat(firstTwoLetters, 4));
            }

            return returnString;
        }
    }
}