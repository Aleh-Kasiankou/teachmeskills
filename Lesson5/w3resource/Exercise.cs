using System;
using System.Collections.Generic;
using System.Linq;

namespace w3resource
{
    public abstract class Exercise
    //TODO
    //Try using dynamic with typechecking in GetOperands methods
    // Convert Get Children to use interface???
    // Add Sorting to GetChildren
    {
        public abstract string Description { get; }

        public abstract void Run();

        public static List<Type> GetAllExercises()
        {
            var listOfExecises = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(domainAssembly => domainAssembly.GetTypes())
                .Where(type => type.IsSubclassOf(typeof(Exercise))
                ).ToList();
            listOfExecises.Reverse();
            return listOfExecises;
        }

        public void DisplayDescription()
        {
            Console.WriteLine($"\nTask: {Description}");
        }

        public void DisplayResult(int result)
        {
            Console.WriteLine($"Output: {result.ToString()}");
        }
        
        public void DisplayResult(string result)
        {
            Console.WriteLine($"Output: {result}");
        }
        
        public void DisplayResult(bool result)
        {
            Console.WriteLine($"Output: {result.ToString()}");
        }
        
        public void DisplayResult(double result)
        {
            Console.WriteLine($"Output: \n{result.ToString()}");
        }

    }
}