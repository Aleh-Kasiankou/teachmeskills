using System.Collections.Generic;
using System.Linq;

namespace w3resource.Exercises.String
{
    public class Exercise10: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to " +
                                                      "find maximum occurring character in a string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var Freequency = new Dictionary<char, int>();
            foreach (char character in userString)
            {
                if (!Freequency.ContainsKey(character))
                {
                    Freequency.Add(character, userString.Count(ch => ch == character));
                }
            }
            
            var mostFrequentChar = (from entry 
                in Freequency orderby entry.Value ascending select entry).First();

            return $"Most Frequent Char with {mostFrequentChar.Value.ToString()} " +
                   $"occurrences is {mostFrequentChar.Key.ToString()}";
        }
    }
}