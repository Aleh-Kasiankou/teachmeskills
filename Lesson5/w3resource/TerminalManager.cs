using System;
using System.Collections.Generic;
using System.Linq;

namespace w3resource
{
    public static class TerminalManager
        //TODO
        //check whether reflection could be used instead of creating a few methods
        //add labels to terminal to give a hint what data is prompted
        //add displaying results for arrays/lists
        //change DisplayResult to interact with user in all the cases, not only for outputting result
        //add sorting to exercises
    {
        private static string CurrentChapter { get; set; } = "";

        private static Dictionary<int, string> Chapters { get; } = InitializeChapters();

        public static void HandleNavigation() // Add exit point
        {
            while (true)
            {
                RenderMenu();
                ProcessMenuNavigation();
            }
        }

        private static void RenderMenu()
        {
            Console.Clear();
            if (CurrentChapter == "")
            {
                foreach (var chapter in Chapters)
                {
                    Console.WriteLine($"{chapter.Key.ToString()}) {chapter.Value}");
                }
            }
            else
            {
                
                foreach (var exercise in GetChapterExercises(CurrentChapter)) 
                {
                    Console.WriteLine($"{exercise.Key.ToString()}) {exercise.Value.Name}");
                }
            }
        }

        private static Dictionary<int, Type> GetChapterExercises(string chapter)
        {
            var exercisesDict = new Dictionary<int, Type>();
            var exerciseId = 1;

            var sortedExercises = Exercise.GetAllExercises().OrderBy(exerc => exerc.Name.Length)
                .ThenBy(exerc => exerc.Name);

            foreach (var exerciseType in sortedExercises) 
            {
                string nameSpace = exerciseType.Namespace.Split(".").Last();
                if (nameSpace == chapter)
                {
                    exercisesDict.Add(exerciseId, exerciseType);
                    exerciseId++;
                }
            }

            return exercisesDict;
        }

        private static void ProcessMenuNavigation()
        {
            Console.WriteLine("\nTo select menu item, please type its id. Type 0 to get to the main menu");
            int id = GetIntOperands(1)[0];

            if (id == 0)
            {
                CurrentChapter = "";
            }
            else if (CurrentChapter == "" && Chapters.ContainsKey(id))
            {
                CurrentChapter = Chapters[id];
            }
            else if (CurrentChapter != "" && GetChapterExercises(CurrentChapter).ContainsKey(id)) {
                var exercise = GetChapterExercises(CurrentChapter)[id];
                ExerciseRunner.RunExercise(exercise);
            }
        }

        private static Dictionary<int, string> InitializeChapters()
        {
            var chaptersDict = new Dictionary<int, string>();
            var chapterId = 1;

            foreach (var exercise in Exercise.GetAllExercises())
            {
                string nameSpace = exercise.Namespace.Split(".").Last();
                if (!chaptersDict.ContainsValue(nameSpace))
                {
                    chaptersDict.Add(chapterId, nameSpace);
                    chapterId++;
                }
            }

            return chaptersDict;
        }

        public static List<int> GetIntOperands(int numberOfOperands)
        {
            List<int> returnArray = new List<int>();
            while (returnArray.Count() < numberOfOperands)
            {
                try
                {
                    Console.WriteLine("Please type your integer number");
                    returnArray.Add(Int32.Parse(Console.ReadLine()));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return returnArray;
        }

        public static List<double> GetDoubleOperands(int numberOfOperands)
        {
            List<double> returnArray = new List<double>();
            while (returnArray.Count() < numberOfOperands)
            {
                try
                {
                    Console.WriteLine("Please type your integer number");
                    returnArray.Add(Double.Parse(Console.ReadLine()));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return returnArray;
        }

        public static List<string> GetStrings(int numberOfStrings)
        {
            List<string> returnArray = new List<string>();
            while (returnArray.Count() < numberOfStrings)
            {
                try
                {
                    Console.WriteLine("Please type your string");
                    returnArray.Add(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return returnArray;
        }

        public static List<char> GetChars(int numberOfChars)
        {
            List<char> returnArray = new List<char>();
            while (returnArray.Count() < numberOfChars)
            {
                try
                {
                    Console.WriteLine("Please type your char");
                    returnArray.Add(Char.Parse(Console.ReadLine()));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return returnArray;
        }

        public static bool PromptIsContinue(string msg = "\nWould you like to rerun exercise? Type \"yes\" to rerun")
        {
            Console.WriteLine(msg);
            return GetStrings(1)[0].ToLower().Trim() == "yes";
        }
    }
}