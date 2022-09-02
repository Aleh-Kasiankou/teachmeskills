using System;

namespace w3resource
{
    public abstract class Exercise
    {
        public abstract string Description { get; }

        public abstract void Run();
        
        
        public void DisplayDescription()
        {
            Console.WriteLine($"Task: {Description}");
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

    }
}