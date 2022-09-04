namespace w3resource.Exercises.Function
{
    public class Exercise1: Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to create a user define function.";

        public override void Run()
        {
            DisplayDescription();
            DisplayResult(Solve());
        }

        public string Solve() => "I am dummy function!";
    }
}