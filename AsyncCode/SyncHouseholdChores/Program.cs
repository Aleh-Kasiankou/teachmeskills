using System;

namespace SyncHouseholdChores
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;
            var person = new Person();
            person.DoHouseholdChores();
            var finishTime = DateTime.Now;
            Console.WriteLine($"Chores took {(finishTime - startTime).Seconds} seconds");
        }
    }
}