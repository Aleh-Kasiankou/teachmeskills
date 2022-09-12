using System;

namespace w3resource.Exercises.String
{
    public class Exercise7: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to count a total number of " +
                                                      "alphabets, digits and special characters in a string.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(1)[0];
            DisplayResult(Solve(userString));
        }

        public string Solve(string userString)
        {
            var digitsCount = 0;
            var alphaCount = 0;
            var specialCharsCount = 0;
            
            for (var i = 0; i < userString.Length; i++)
            {
                var character = Char.Parse(userString.Substring(i,1));
                
                if (char.IsDigit(character))
                {
                    digitsCount += 1;
                } else if (Char.IsLetter(character))
                {
                    alphaCount += 1;
                }
                else
                {
                    specialCharsCount += 1;
                }
            }

            return $"Digits: {digitsCount.ToString()}\nAlpha: {alphaCount.ToString()}" +
                   $"\nOther: {specialCharsCount.ToString()}";
        }
    }
}