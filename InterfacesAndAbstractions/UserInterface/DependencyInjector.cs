using System;
using System.Collections.Generic;

namespace UserInterface
{
    public static class DependencyInjector
    {
        public static Action<string, List<ConsoleColor>> GetShapeOutputMethod(UiHandler uiInstance)
        {
            OutputMethod userSelectedMethod = uiInstance.PromptForOutputMethod();

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

        public static Action<string, bool> GetUiOutputMethod(UiHandler uiInstance)
        {
            Action<string, bool> uiOutputMethod = ConsoleHandler.OutputData;
            return uiOutputMethod;
        }
        
        public static Func<string> GetUiInputMethod(UiHandler uiInstance)
        {
            Func<string> uiInputMethod = ConsoleHandler.HandleUserInput;
            Func<ConsoleKeyInfo> keyDetectMethod = ConsoleHandler.HandleUserKeyPress;
            uiInstance.DetectKeyPress = keyDetectMethod;
            return uiInputMethod;
        }
        

        public static Action GetContinueProgramAction(UiHandler uiInstance)
        // switch to events
        {
            Action continueProgramDelegate = uiInstance.RenderMainMenu;
            return continueProgramDelegate;
        }

        public static Action GetAddShapeAction(UiHandler uiInstance)
        {
            Action addShapeDelegate = uiInstance.AddShapeToQueue;
            return addShapeDelegate;
        }
    }
}