using System.Linq;

namespace w3resource.Exercises.Data_Types
{
    public class Exercise9: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes a character as input " +
                                                      "and check the input (lowercase) " +
                                                      "is a vowel, " +
                                                      "a digit, " +
                                                      "or any other symbol.";

        public override void Run()
        {
            DisplayDescription();
            var userChar = TerminalManager.GetChars(1);
            DisplayResult(Solve(userChar[0]));
        }

        public string Solve(char userChar)
        {
            char[] vowels = new char[] { 'a', 'e','o', 'i','u'};
            char[] digits = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            
            if (vowels.Contains(char.ToLower(userChar)))
            {
                return "vowel";
            }
            
            if (digits.Contains(char.ToLower(userChar)))
            {
                return "digit";
            }

            return "Now a vowel or a digit";
        }
    }
}