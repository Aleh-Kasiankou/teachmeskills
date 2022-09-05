namespace w3resource.Exercises.Conditional_Statements
{
    public class Exercise10: Exercise
    {
        public override string Description { get; } = " Write a C# Sharp program to find the eligibility of admission " +
                                                      "for a professional course based on the following criteria:" +
                                                      "Marks in Maths( 1st input ) >=65" +
                                                      "Marks in Phy ( 2nd input ) >=55 + " +
                                                      "Marks in Chem ( 3rd input ) >=50" +
                                                      "\nTotal in all three subject >=180" +
                                                      "\nor Total in Math and Physics >=140";

        public override void Run()
        {
            DisplayDescription();
            var operands = TerminalManager.GetDoubleOperands(3);
            DisplayResult(Solve(operands[0], operands[1], operands[2]));
        }

        public string Solve(double math, double physics, double chemistry)
        {
            if (math >= 65 && physics >= 55 && chemistry >= 50)
            {
                var isTotalPointsEligible = (math + physics + chemistry) >= 180 ;
                var isMathAndPhysicsEligible = math + physics >= 140;

                if (isTotalPointsEligible || isMathAndPhysicsEligible)
                {
                    return "Eligible for admission";
                }
            }
            return "Not eligible";
        }
    }
}