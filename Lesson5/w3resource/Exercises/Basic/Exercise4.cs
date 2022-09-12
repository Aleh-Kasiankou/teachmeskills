namespace w3resource.Exercises.Basic
{
    public class Exercise4: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to print the result " +
                                                      "of the specified operations:" +
                                                      "\n-1 + 4 * 6" +
                                                      "\n( 35+ 5 ) % 7" +
                                                      "\n14 + -4 * 6 / 11" +
                                                      "\n2 + 15 / 6 * 1 - 7 % 2";

        public override void Run()
        {
                        DisplayResult(Solve());
        }

        public string Solve()
        {
            return $"\n-1 + 4 * 6 = {(-1 + 4 * 6).ToString()}" +
                   $"\n( 35+ 5 ) % 7 = {(( 35 + 5 ) % 7).ToString()}" +
                   $"\n14 + -4 * 6 / 11 = {(14 + -4 * 6 / 11).ToString()}" +
                   $"\n2 + 15 / 6 * 1 - 7 % 2 = {(2 + 15 / 6 * 1 - 7 % 2).ToString()}";
        }
    }
}