using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHouseholdChores
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationSource = new CancellationTokenSource();
            
            var person = new Person();
            var house = new House();
            
            Console.WriteLine("Press any key to stop doing chores");
            Task.Factory.StartNew(() =>
            {
                Console.ReadKey();
                cancellationSource.Cancel();
            });
            
            var startTime = DateTime.Now;
            var satisfaction = await person.DoHouseholdChores(house, cancellationSource.Token);
            var finishTime = DateTime.Now;
            Console.WriteLine($"Chores took {(finishTime - startTime).Seconds} seconds");
            await person.HaveFun(satisfaction);
        }
    }
}