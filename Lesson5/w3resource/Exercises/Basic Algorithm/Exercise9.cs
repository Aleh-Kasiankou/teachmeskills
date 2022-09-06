using System.Collections.Generic;

namespace w3resource.Exercises.Basic_Algorithm
{
    public class Exercise9 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to create a new string with the last char added " +
            "at the front and back of a given string of length 1 or more.";


        public override void Run()
        {
            List<string> inputStrings = TerminalManager.GetStrings(1);
            DisplayResult(Solve(inputStrings[0]));
        }

        public string Solve(string userString)
        {
            var returnString = "Empty String";
            if (userString.Length > 0)
            {
                var lastChar = userString.Substring(userString.Length - 1, 1);
                returnString = userString.Insert(0, lastChar).Insert(userString.Length - 1, lastChar);
            }

            return returnString;
        }
    }
}