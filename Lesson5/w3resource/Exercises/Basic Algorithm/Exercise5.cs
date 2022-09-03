using System.Collections.Generic;

namespace w3resource.Exercises.Basic_Algorithm
{
    public class Exercise5 : Exercise
    {
        public override string Description =>
            "Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. " +
            "If the string already begins with 'if' (case-insensitive), return the string unchanged";


        public override void Run()
        {
            DisplayDescription();
            List<string> inputStrings = TerminalManager.GetStrings(1);
            DisplayResult(Solve(inputStrings[0]));

        }
        
        public string Solve(string userString)
        {
            bool isAddIf = false;
            if (userString.Length >= 2)
            {
                isAddIf = userString.Substring(0, 2).ToLower() != "if";
            }

            return isAddIf ? "if " + userString : userString;
        }
        
    }
}