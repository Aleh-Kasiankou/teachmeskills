using System;

namespace ShapePrinter
{
    public static class PrintableFactory
    {
        public static IPrintable CreatePrintableObject(Type printableType)
        {
            IPrintable objToPrint;
            if (printableType == typeof(PrintableText))
            {
                var text = UiHandler.GetText();
                objToPrint =
                    (IPrintable)Activator.CreateInstance(printableType, new object[] { text });
            }
            else
            {
                var printableChar = UiHandler.GetPrintingChar();
                var size = UiHandler.GetSize();
                objToPrint =
                    (IPrintable)Activator.CreateInstance(printableType, new object[] { size, printableChar });
            }

            return objToPrint;
        }
    }
}