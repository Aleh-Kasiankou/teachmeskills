using System.Collections.Generic;

namespace w3resource.Exercises.Basic_Algorithm
{
    public class Exercise7 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to exchange the first and last characters in " +
            "a given string and return the new string.";


        public override void Run()
        {
            DisplayDescription();
            List<string> inputStrings = TerminalManager.GetStrings(1);
            DisplayResult(Solve(inputStrings[0]));

        }
        
        public string Solve(string userString)
        {
            var returnString = "Your string is too short";
            if (userString.Length > 1)
            {
                var firstLetter = userString.Substring(0, 1);
                var lastLetter = userString.Substring(userString.Length - 1, 1);
                returnString = userString.Remove(0, 1).Insert(0, lastLetter);
                returnString = returnString.Remove(userString.Length - 1, 1)
                    .Insert(userString.Length - 1, firstLetter);
            }

            return returnString;
        }
    }
}