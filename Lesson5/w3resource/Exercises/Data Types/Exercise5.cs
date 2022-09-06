using System;

namespace w3resource.Exercises.Data_Types
{
    public class Exercise5: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes " +
                                                      "the radius of a circle as input " +
                                                      "and calculate the perimeter and area of the circle.";

        public override void Run()
        {
            var operandsList = TerminalManager.GetDoubleOperands(1);
            DisplayResult(Solve(operandsList[0]));
        }

        public string Solve(double radius)
        {
            var perimeter = 2 * 3.14159 * radius;
            var area = Math.Pow(radius, 2) * 3.14159;
            return $"Perimeter = {perimeter.ToString()}\nArea = {area.ToString()}";
        }
    }
}