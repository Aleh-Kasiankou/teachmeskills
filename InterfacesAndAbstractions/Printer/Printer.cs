using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharedAssets;

namespace Printer
{
    public class Printer
    {
        private List<PrinterQueueElement> Queue { get; set; } = new List<PrinterQueueElement>();

        public List<HistoryRecord> History { get; private set; } = new List<HistoryRecord>();

        public event EventHandler PrintEvent;
        public event EventHandler<HistoryArgs> QueueMergeEvent;

        public Printer()
        {
            PrintEvent += ClearQueue;
            QueueMergeEvent += AddToHistory;
        }

        public void AddToQueue(List<CoordinatesPoint> printableScheme, CoordinatesPoint startingPoint, Type objType)
        {
            printableScheme = PrintHelper.ConvertToPositiveCoordinates(printableScheme);
            printableScheme = PrintHelper.MoveStartingPoint(printableScheme, startingPoint);
            printableScheme = PrintHelper.SetColor(printableScheme, objType);
            Queue.Add(new PrinterQueueElement(objType, printableScheme));
        }

        private void ClearQueue(object sender, EventArgs args)
        {
            Queue = new List<PrinterQueueElement>();
        }


        private List<CoordinatesPoint> MergeQueue()
        {
            var drawingScheme = new List<CoordinatesPoint>();
            foreach (var queueElement in Queue)
            {
                List<PrinterQueueElement> printedWith = Queue.FindAll(el => !Equals(el, queueElement)).ToList();
                drawingScheme.AddRange(queueElement.DrawingScheme);
                OnQueueMergeEvent(new HistoryArgs(queueElement.Type, printedWith));
            }

            drawingScheme = PrintHelper.SortPointsByYAndX(drawingScheme);

            return drawingScheme;
        }

        private static string ConvertSchemeToString(List<CoordinatesPoint> drawingScheme,
            out List<ConsoleColor> colorScheme)
        {
            var textScheme = new StringBuilder();
            colorScheme = new List<ConsoleColor>();

            var lastPointY = 1;
            if (drawingScheme[0].Y > 1)
            {
                textScheme.Append(String.Concat(Enumerable.Repeat("\n", drawingScheme[0].Y - 1)));
            }

            for (int index = 0; index < drawingScheme.Count; index++)
            {
                var point = drawingScheme[index];
                var margin = "";
                if (point.Y != lastPointY)
                {
                    margin = "\n";
                }

                var spacesNeeded = PrintHelper.CalculateLeftMargin(drawingScheme, index, out bool isSkip);
                if (isSkip)
                {
                    continue;
                }

                if (spacesNeeded > 0)
                {
                    margin += String.Concat(Enumerable.Repeat(" ", spacesNeeded));
                }


                textScheme.Append(margin + point.Symbol);
                if (!char.IsWhiteSpace(point.Symbol))
                {
                    colorScheme.Add(point.Color);
                }

                lastPointY = point.Y;
            }

            return textScheme.ToString();
        }

        private void AddToHistory(object sender, HistoryArgs args)
        {
            var historyElement = new HistoryRecord(args.Type, args.PrintedWith);
            History.Add(historyElement);
        }

        public void Print(Action<string, List<ConsoleColor>> outputString)
        {
            var drawingScheme = MergeQueue();
            var textScheme = ConvertSchemeToString(drawingScheme, out var colorScheme);
            outputString(textScheme, colorScheme);
            OnPrintEvent();
        }

        protected virtual void OnPrintEvent()
        {
            PrintEvent?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnQueueMergeEvent(HistoryArgs e)
        {
            QueueMergeEvent?.Invoke(this, e);
        }
    }
}