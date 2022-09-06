namespace w3resource.Exercises.String
{
    public class Exercise6: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to " +
                                                      "compare two string without using string library functions.";

        public override void Run()
        {
            var userString = TerminalManager.GetStrings(2);
            DisplayResult(Solve(userString[0].ToLower().Trim(), userString[1].ToLower().Trim()));
        }

        public string Solve(string userString1, string userString2 )
        {
            var notEqualMsg = "Not Equal";
            
            if (userString1.Length != userString2.Length)
            {
                return notEqualMsg;
            }

            for (var i = 0; i < userString1.Trim().Length; i++)
            {
                if (userString1[i] != userString2[i])
                {
                    return notEqualMsg;
                }
            }

            return "Equal";
        }
    }
}