﻿using System;

namespace SharedAssets
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ColorAttribute : Attribute
    {
        public ConsoleColor Color { get; }

        public ColorAttribute(ConsoleColor color = ConsoleColor.White)
        {
            Color = color;
        }
    }
}