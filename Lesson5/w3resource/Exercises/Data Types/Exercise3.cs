namespace w3resource.Exercises.Data_Types
{
    public class Exercise3: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes " +
                                                      "userid and password as input (type string). " +
                                                      "After 3 wrong attempts, user will be rejected.";

        public override void Run()
        {
            DisplayResult(Solve("Admin", "Admin", 3));

        }

        public string Solve(string validUserId, string validPassword, int numberAttemptsAllowed)
        {
            for (var attempts = 1; attempts <= numberAttemptsAllowed; attempts++)
            {
                var credentials = TerminalManager.GetStrings(2);
                if (credentials[0] == validUserId && credentials[1] == validPassword)
                {
                    return "You've successfully logged in!";
                }

            }

            return "Authentication failed";
        }
    }
}