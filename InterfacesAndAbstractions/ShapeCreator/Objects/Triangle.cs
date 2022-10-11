// using System;
// using System.Collections.Generic;
//
// namespace ShapePrinter
// {
//     public class Triangle : Shape
//     {
//         public Triangle(int size, char printingChar) : base(size, printingChar)
//         {
//         }
//
//         public override List<(int, int, char)> GetPrintingScheme()
//         {
//             var printingPoints = new List<(int x, int y, char Delimiter)>();
//             var halfSize = Size / 2;
//             var x = -halfSize;
//             var y = -halfSize;
//             while (y <= halfSize)
//             {
//                 var y1 = y < 0 ? -halfSize : halfSize;
//
//                 var dx1 = halfSize - -halfSize;
//                 var dy1 = 0 - y1;
//
//                 var dx = x - -halfSize;
//                 var dy = y - y1;
//
//                 var S = dx1 * dy - dx * dy1;
//
//                 if (x == -halfSize || (y == 0 && x == halfSize) || S == 0)
//                 {
//                     printingPoints.Add(new ValueTuple<int, int, char>(x, y, Delimiter));
//                 }
//
//
//                 if (x >= halfSize)
//                 {
//                     y++;
//                     x = -halfSize;
//                     continue;
//                 }
//
//                 x++;
//             }
//
//             return printingPoints;
//         }
//     }
// }

