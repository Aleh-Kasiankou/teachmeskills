using System;
using System.Threading.Tasks;

namespace AsyncHouseholdChores
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var person = new Person();
            var startTime = DateTime.Now;
            await person.DoHouseholdChores();
            var finishTime = DateTime.Now;
            Console.WriteLine($"Chores took {(finishTime - startTime).Seconds} seconds");
        }
    }
}