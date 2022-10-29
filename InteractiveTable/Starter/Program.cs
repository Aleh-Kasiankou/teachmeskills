using System;
using UserInterface;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new Ui();
            Exception exceptionToPrint = null;
            while (true)
            {
                try
                {
                    ui.Start(exceptionToPrint);
                }

                catch (Exception e)
                {
                    exceptionToPrint = e;
                }
            }
            


        }
    }
}