using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Exceptions
{
    public static class PassValidator
    {
        public static void Validate(string password)
        {
            List<Exception> validationErrors = CheckForExceptions(password);
            WarnUser(validationErrors);
        }

        private static List<Exception> CheckForExceptions(string password)
        {
            var exceptionsList = new List<Exception>();

            var checkList = new Dictionary<string, (bool, Exception)>()
            {
                { "containsNonLetterSymbols", (false, new ContainsOnlyLettersException()) },
                { "ContainsNonDigits", (false, new ContainsOnlyDigitsException()) },
                { "ContainsSpecChars", (false, new NoSpecCharsException()) },
                { "ContainsCapitalLetter", (false, new NoCapitalLetterException()) },
                { "ContainsLowerCaseLetter", (false, new NoLowerCaseLetterException()) },
                { "IsLongEnough", (false, new IsTwoShortException()) },
            };


            foreach (char symbol in password)
            {
                if (!char.IsLetter(symbol))
                {
                    var valueTuple = checkList["containsNonLetterSymbols"];
                    valueTuple.Item1 = true;
                    checkList["containsNonLetterSymbols"] = valueTuple;
                }

                if (!char.IsDigit(symbol))
                {
                    var valueTuple = checkList["ContainsNonDigits"];
                    valueTuple.Item1 = true;
                    checkList["ContainsNonDigits"] = valueTuple;
                }

                if (char.IsSymbol(symbol))
                {
                    var valueTuple = checkList["ContainsSpecChars"];
                    valueTuple.Item1 = true;
                    checkList["ContainsSpecChars"] = valueTuple;
                }

                if (char.IsLetter(symbol))
                {
                    if (char.ToUpper(symbol) == symbol)
                    {
                        var valueTuple = checkList["ContainsCapitalLetter"];
                        valueTuple.Item1 = true;
                        checkList["ContainsCapitalLetter"] = valueTuple;
                    }

                    else if (char.ToLower(symbol) == symbol)
                    {
                        var valueTuple = checkList["ContainsLowerCaseLetter"];
                        valueTuple.Item1 = true;
                        checkList["ContainsLowerCaseLetter"] = valueTuple;
                    }
                }
            }

            if (password.Length >= 14)
            {
                var valueTuple = checkList["IsLongEnough"];
                valueTuple.Item1 = true;
                checkList["IsLongEnough"] = valueTuple;
            }

            foreach (var check in checkList)
            {
                if (!check.Value.Item1)
                {
                    exceptionsList.Add(check.Value.Item2);
                }
            }

            return exceptionsList;
        }

        private static void WarnUser(List<Exception> exceptionToThrow)
        {
            try
            {
                foreach (var exception in exceptionToThrow)
                {
                    throw exception;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                exceptionToThrow.Remove(exceptionToThrow[0]);
                WarnUser(exceptionToThrow);
            }
        }


        public class ContainsOnlyLettersException : Exception
        {
            public override string Message { get; } = "Password contains only letters";
        }

        public class ContainsOnlyDigitsException : Exception
        {
            public override string Message { get; } = "Password contains digits";
        }

        public class NoSpecCharsException : Exception
        {
            public override string Message { get; } = "Password should contain special symbols";
        }

        public class NoCapitalLetterException : Exception
        {
            public override string Message { get; } = "At least one letter in password should be capitalized";
        }

        public class NoLowerCaseLetterException : Exception
        {
            public override string Message { get; } = "Password should include at least one lowercase letter";
        }

        public class IsTwoShortException : Exception
        {
            public override string Message { get; } = "Password should be longer than 13 symbols";
        }
    }
}