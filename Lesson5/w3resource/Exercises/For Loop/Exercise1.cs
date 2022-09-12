namespace w3resource.Exercises.For_Loop
{
    public class Exercise1: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display the first 10 " +
                                                      "natural numbers.";

        public override void Run()
        {
            DisplayResult(Solve());
        }

        public string Solve()
        {
            var naturalNumbers = "";

            for (var i = 1; i <= 10; i++)
            {
                naturalNumbers += " " + i;
            }

            return naturalNumbers;
        }
    }
}