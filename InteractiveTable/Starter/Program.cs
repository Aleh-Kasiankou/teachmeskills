using System;
using UserInterface;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new Ui();
            while (true)
            {
                try
                {
                    ui.Start();
                }

                catch (Exception e)
                {
                    ui.NotifyAboutCriticalError(e);
                }
            }
            


        }
    }
}