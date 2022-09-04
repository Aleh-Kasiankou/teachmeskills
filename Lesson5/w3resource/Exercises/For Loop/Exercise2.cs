namespace w3resource.Exercises.For_Loop
{
    public class Exercise2: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program to find the sum of " +
                                                      "first 10 natural numbers.";

        public override void Run()
        {
            DisplayDescription();
            DisplayResult(Solve());
        }

        public int Solve()
        {
            var naturalNumbers = 0;

            for (var i = 1; i <= 10; i++)
            {
                naturalNumbers += i;
            }

            return naturalNumbers;
        }
    }
}