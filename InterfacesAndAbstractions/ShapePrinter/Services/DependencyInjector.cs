using System;
using System.Collections.Generic;

namespace ShapePrinter.Services
{
    public static class DependencyInjector
    {
        public static Action<string, List<ConsoleColor>> GetShapeOutputMethod()
        {
            OutputMethod userSelectedMethod = UiHandler.PromptForOutputMethod();

            Action<String, List<ConsoleColor>> outputMethod;

            if (userSelectedMethod is OutputMethod.Console)
            {
                outputMethod = ConsoleHandler.OutputPrintingScheme;

            }
            else
            {
                outputMethod = FileHandler.WriteSchemeToFile;
            }

            return outputMethod;
        }

        public static Action<string, bool> GetUiOutputMethod()
        {
            Action<string, bool> uiOutputMethod = ConsoleHandler.OutputData;
            return uiOutputMethod;
        }
        
        public static Func<string> GetUiInputMethod()
        {
            Func<string> uiInputMethod = ConsoleHandler.HandleUserInput;
            Func<ConsoleKeyInfo> keyDetectMethod = ConsoleHandler.HandleUserKeyPress;
            UiHandler.DetectKeyPress = keyDetectMethod;
            return uiInputMethod;
        }
        

        public static Action GetContinueProgramAction()
        {
            Action continueProgramDelegate = UiHandler.RunDialog;
            return continueProgramDelegate;
        }

        public static Action GetAddShapeAction()
        {
            Action addShapeDelegate = UiHandler.StartUiPrintableConstructor;
            return addShapeDelegate;
        }
    }
}