using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHouseholdChores
{
    public class Person
    {
        public async Task DoHouseholdChores()
        {
            Task washingClothes = WashClothes();
            Task listeningToMusic = ListenToMusic();
            CleanDust();
            VacuumCarpet();
            Task washingFloor = WashFloor();
            Task cleaningBath = CleanBath();

            await washingFloor;
            await cleaningBath;
            await washingClothes;
            await listeningToMusic;
        }

        private void CleanDust()
        {
            Console.WriteLine("Looking for a duster");
            Console.WriteLine("Moistening the duster");
            Console.WriteLine("Cleaning furniture in the 1st room");
            Console.WriteLine("Moistening the duster");
            Console.WriteLine("Cleaning furniture in the 2nd room");
            Console.WriteLine("Putting the duster back");
        }
        
        private async Task WashFloor()
        {
            Console.WriteLine("Putting a basin under water");
            await Task.Delay(600);
            Console.WriteLine("Washing floor in the 1st room");
            Console.WriteLine("Washing floor in the 2nd room");
            Console.WriteLine("Emptying the basin and cleaning it");
        }

        private async Task WashClothes()
        {
            Console.WriteLine("Putting clothes into washing machine");
            Console.WriteLine("Turning on the machine");
            await Task.Delay(6000);
            Console.WriteLine("Taking the clothes out and hanging them");
        }

        private void VacuumCarpet()
        {
            Console.WriteLine("Turning on a vacuum cleaner");
            Console.WriteLine("Vacuuming a carpet in the second room"); 
            Console.WriteLine("Putting the vacuum cleaner back");
        }

        private async Task CleanBath()
        {
            Console.WriteLine("Spreading detergent over the bath and leaving for some time");
            await Task.Delay(2500);
            Console.WriteLine("Thoroughly running the bath");
            Console.WriteLine("Washing the detergent off with water");
        }

        private async Task ListenToMusic()
        {
            Console.WriteLine("Turning on the music");
            await Task.Delay(4500);
            Console.WriteLine("Turning off the music");
        }


    }
}