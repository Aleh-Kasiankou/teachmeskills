using System;
using System.Threading.Tasks;

namespace AsyncHouseholdChores
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var person = new Person();
            var house = new House();
            var startTime = DateTime.Now;
            var satisfaction = await person.DoHouseholdChores(house);
            var finishTime = DateTime.Now;
            Console.WriteLine($"Chores took {(finishTime - startTime).Seconds} seconds");
            await person.HaveFun(satisfaction);
        }
    }
}