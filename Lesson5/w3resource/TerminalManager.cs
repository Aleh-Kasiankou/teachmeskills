using System;
using System.Collections.Generic;
using System.Linq;

namespace w3resource
{
    public static class TerminalManager 
        //TODO
        //check whether reflection could be used instead of creating a few methods
        //add labels to terminal to give a hind what data is prompted
        //add displaying results for arrays/lists
        //change DisplayResult to interact with user in all the cases, not only for outputing result
    {
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
    }
}