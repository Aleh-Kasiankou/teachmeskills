namespace w3resource.Exercises.For_Loop
{
    public class Exercise8 : Exercise
    {
        public override string Description { get; } = "Write a program in C# Sharp to display the n terms of " +
                                                      "odd natural number and their sum.";

        public override void Run()
        {
            var terms = TerminalManager.GetIntOperands(1)[0];
            DisplayResult(Solve(terms));
        }

        public string Solve(int terms)
        {
            var naturalNumbersString = "";
            var naturalNumbersSum = 0;

            for (var i = 1; i <= terms; i++)
            {
                var oddNumber = (i * 2 - 1);
                naturalNumbersString += " " + oddNumber ;
                naturalNumbersSum += oddNumber;
            }


            return
                $"First {terms.ToString()} numbers: {naturalNumbersString}\n Their Sum: {naturalNumbersSum.ToString()}";
        }
    }
}