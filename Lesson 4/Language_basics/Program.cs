using System;

namespace Language_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what should I call you?");
            SetName(out var name);
            Console.WriteLine($"Hello {name}! Nice to meet you!");
        }

        static void SetName(out string name)
        {
            name = Console.ReadLine();
        }
        
    }
}