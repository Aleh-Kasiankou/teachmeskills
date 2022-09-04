namespace w3resource.Exercises.Data_Types
{
    public class Exercise7 : Exercise
    {
        public override string Description { get; } =
            "Write a C# Sharp program that takes distance(kms) and time (hours) as input " +
            "and displays the speed in kilometres per hour and miles per hour.";

        public override void Run()
        {
            DisplayDescription();
            var operands = TerminalManager.GetDoubleOperands(2);
            DisplayResult(Solve(operands[0], operands[1]));
        }

        public string Solve(double distance, double time)
        {
            if (distance > 0 && time > 0)
            {
                var speedKPH = distance / time;
                var speedMPH = speedKPH * 0.6213;

                return $"Speed:\n {speedKPH.ToString()} KPH\n {speedMPH.ToString()} MPH";
            }
            else
            {
                return "The conditions are invalid";
            }
        }
    }
}