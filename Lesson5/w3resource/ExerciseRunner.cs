using System;

namespace w3resource
{
    public static class ExerciseRunner
    {
        private static bool isContinue = false;
        private static Exercise _currentExercise;
        

            public static void RunExercise(Type exerciseType)
            {
                do
                {
                    try
                    {
                        SetCurrentExercise(exerciseType);
                        _currentExercise.DisplayDescription();
                        _currentExercise.Run();
                        isContinue = TerminalManager.PromptIsContinue();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        TerminalManager.HandleNavigation();
                    }
                } while (isContinue);
            }

            private static void SetCurrentExercise(Type exerciseType)
            {
                _currentExercise = (Exercise)Activator.CreateInstance(exerciseType);
            }
    }
}