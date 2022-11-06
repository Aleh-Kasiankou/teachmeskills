using System;
using System.Threading;

namespace SyncHouseholdChores
{
    public class Person
    {
        public void DoHouseholdChores()
        {
            WashClothes();
            ListenToMusic();
            CleanDust();
            VacuumCarpet();
            WashFloor();
            CleanBath();
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
        
        private void WashFloor()
        {
            Console.WriteLine("Putting a basin under water");
            Thread.Sleep(600);
            Console.WriteLine("Washing floor in the 1st room");
            Console.WriteLine("Washing floor in the 2nd room");
            Console.WriteLine("Emptying the basin and clean it");
        }

        private void WashClothes()
        {
            Console.WriteLine("Putting clothes into washing machine");
            Console.WriteLine("Turning on the machine");
            Thread.Sleep(6000);
            Console.WriteLine("Taking the clothes out and hanging them");
        }

        private void VacuumCarpet()
        {
            Console.WriteLine("Turning on vacuum cleaner");
            Console.WriteLine("Vacuuming a carpet in the second room"); 
            Console.WriteLine("Putting the vacuum cleaner back");
        }

        private void CleanBath()
        {
            Console.WriteLine("Spreading detergent over the bath and leaving for some time");
            Thread.Sleep(2500);
            Console.WriteLine("Thoroughly running the bath");
            Console.WriteLine("Washing the detergent off with water");
        }

        private void ListenToMusic()
        {
            Console.WriteLine("Turning on the music");
            Thread.Sleep(4500);
            Console.WriteLine("Turning off the music");
        }


    }
}