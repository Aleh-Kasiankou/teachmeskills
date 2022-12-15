using System;
using System.Threading;
using System.Threading.Tasks;

namespace breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WakeUp();
            TurnOnTv();
            var teaMaking = MakeTea();
            var omeletteCooking = MakingOmelette();
            WashDishes();
            var toastMaking = MakeToast();
            await teaMaking;
            var omelette = await omeletteCooking;
            var toast = await toastMaking;
            MakeSandwich(omelette, toast);
        }

        private static void WakeUp()
        {
            Console.WriteLine("Waking Up");
        }

        private static void TurnOnTv()
        {
            Console.WriteLine("Switching on TV");
        }

        private static async Task MakeTea()
        {
            Console.WriteLine($"Filling a kettle with water {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Turning the kettle on {Thread.CurrentThread.ManagedThreadId}");
            var boilingWaterTask = Task.Delay(2000);
            await boilingWaterTask;

            Console.WriteLine($"Putting a teabag into a mug {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Pouring boiling water to the mug {Thread.CurrentThread.ManagedThreadId}");

            var makingTeaTask = Task.Delay(2000);
            await makingTeaTask;

            Console.WriteLine($"Removing the teabag from the mug {Thread.CurrentThread.ManagedThreadId}");
        }

        private static async Task<Omelette> MakingOmelette()
        {
            Console.WriteLine($"Putting a pan on fire {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);
            Console.WriteLine($"Adding oil to the frying pan {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Breaking eggs {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(2000);
            Console.WriteLine($"Taking the pan off the fire {Thread.CurrentThread.ManagedThreadId}");
            return new Omelette();
        }

        private static void WashDishes()
        {
            Console.WriteLine("Dishwashing");
        }

        private static async Task<Toast> MakeToast()
        {
            Console.WriteLine($"Cutting bread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Putting a loaf of bread into a toaster {Thread.CurrentThread.ManagedThreadId}" );
            await Task.Delay(2000);
            Console.WriteLine($"Taking a toast out of the toaster {Thread.CurrentThread.ManagedThreadId}");
            return new Toast();
        }

        private static void MakeSandwich(Omelette omelette, Toast toast)
        {
            Console.WriteLine("Making sandwich of omelette and toast");
        }
    }
}