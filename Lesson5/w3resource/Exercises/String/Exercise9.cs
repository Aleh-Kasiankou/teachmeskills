using System;
using System.Linq;

namespace w3resource.Exercises.String
{
    public class Exercise9: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to count a " +
                                                      "total number of vowel or consonant in a string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var vowelsCount = 0;
            var consonantsCount = 0;
            var vowels = new char[] { 'a','e','i','o','u'};
            
            for (var i = 0; i < userString.Length; i++)
            {
                var character = Char.Parse(userString.Substring(i,1));
                
                if (Char.IsLetter(character))
                {
                    if (vowels.Contains(character))
                    {
                        vowelsCount += 1;
                    }
                    else
                    {
                        consonantsCount += 1;
                    }
                }
            }

            return $"Vowels: {vowelsCount.ToString()}\nConsonants: {consonantsCount.ToString()}";
        }
    }
}