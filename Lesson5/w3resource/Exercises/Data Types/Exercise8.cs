using System;

namespace w3resource.Exercises.Data_Types
{
    public class Exercise8: Exercise
    {
        public override string Description { get; } = "Write a C# Sharp program that takes the radius of a sphere as input " +
                                                      "and calculate and display the surface and volume of the sphere.";

        public override void Run()
        {
            var operandsList = TerminalManager.GetDoubleOperands(1);
            DisplayResult(Solve(operandsList[0]));
        }

        public string Solve(double radius)
        {
            var surface = radius == 0? 0: 4 * 3.14159 * Math.Pow(radius, 2);
            var volume = radius == 0? 0:Math.Pow(radius, 3) * 3.14159 * 4/3;
            return $"Surface = {surface.ToString()}\nVolume = {volume.ToString()}";
        }
    }
}