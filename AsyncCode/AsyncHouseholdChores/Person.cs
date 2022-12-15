using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AsyncHouseholdChores.Feelings;
using AsyncHouseholdChores.Household;

namespace AsyncHouseholdChores
{
    public class Person
    {
        public async Task<Satisfaction> DoHouseholdChores(House house, CancellationToken token)
        {
            var unfinishedChores = new List<Task<IChoreResult>>();
            
            unfinishedChores.Add(WashClothes());
            Task listeningToMusic = ListenToMusic();
            house.Furniture = CleanDust();
            house.Carpet = VacuumCarpet();
            unfinishedChores.Add(WashFloor());
            unfinishedChores.Add(CleanBath());

            Task.WaitAll(unfinishedChores.ToArray(), token);
            
            foreach (var task in unfinishedChores)
            {
                if (task.Result.GetType() == typeof(Clothing))
                {
                    house.Clothing = task.Result as Clothing;
                }

                else if(task.Result.GetType() == typeof(Floor))
                {
                    house.Floor = task.Result as Floor;
                }

                else if(task.Result.GetType() == typeof(Bath))
                {
                    house.Bath = task.Result as Bath;
                }

                else
                {
                    throw new ArgumentException("Unexpected chore was done");
                }
                
            }
            await listeningToMusic;
            Console.WriteLine("No more chores left");
            return new Satisfaction();
        }

        private Furniture CleanDust()
        {
            Console.WriteLine("Looking for a duster");
            Console.WriteLine("Moistening the duster");
            Console.WriteLine("Cleaning furniture in the 1st room");
            Console.WriteLine("Moistening the duster");
            Console.WriteLine("Cleaning furniture in the 2nd room");
            Console.WriteLine("Putting the duster back");
            return new Furniture(State.Appealing);
        }

        private async Task<IChoreResult> WashFloor()
        {
            Console.WriteLine("Putting a basin under water");
            await Task.Delay(600);
            Console.WriteLine("Washing floor in the 1st room");
            Console.WriteLine("Washing floor in the 2nd room");
            Console.WriteLine("Emptying the basin and cleaning it");
            return new Floor(State.Appealing);
        }

        private async Task<IChoreResult> WashClothes()
        {
            Console.WriteLine("Putting clothes into washing machine");
            Console.WriteLine("Turning on the machine");
            await Task.Delay(6000);
            Console.WriteLine("Taking the clothes out and hanging them");
            return new Clothing(State.Appealing);
        }

        private Carpet VacuumCarpet()
        {
            Console.WriteLine("Turning on a vacuum cleaner");
            Console.WriteLine("Vacuuming a carpet in the second room");
            Console.WriteLine("Putting the vacuum cleaner back");
            return new Carpet(State.Appealing);
        }

        private async Task<IChoreResult> CleanBath()
        {
            Console.WriteLine("Spreading detergent over the bath and leaving for some time");
            await Task.Delay(2500);
            Console.WriteLine("Thoroughly running the bath");
            Console.WriteLine("Washing the detergent off with water");

            return new Bath(State.Appealing);
        }

        private async Task ListenToMusic()
        {
            Console.WriteLine("Turning on the music");
            await Task.Delay(4500);
            Console.WriteLine("Turning off the music");
        }

        public async Task<Feeling> HaveFun(Satisfaction satisfaction)
        {
            Console.WriteLine("Feeling awesome!");
            await Task.Delay(8000); // Being Messy
            return new Anxiety();
        }
    }
}