using System;
using System.Linq;

namespace w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var Exercise in Exercise.GetAllExercises())
            {
                string nameSpace = Exercise.Namespace.Split(".").Last();
                Console.WriteLine(nameSpace + "/" + Exercise.Name);
            }
        }
    }
}