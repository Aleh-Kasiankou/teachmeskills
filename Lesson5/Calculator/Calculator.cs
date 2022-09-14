using System;
using System.Collections.Generic;
using System.Linq;
using Calculator.Operations;

namespace Calculator
{
    public static class Calculator
    {
        public static List<List<string>> Memory = new List<List<string>>();

        private static readonly Dictionary<Type, string[]> AvailableOperations = GetAvailableOperations();
        public static readonly List<string> AvailableOperationSymbols = GetAvailableOperationSymbols();

        public static double Calculate(string expression)
        {
            do
            {
                expression = SimplifyExpression(expression);
                expression = Validator.ResolveSymbolCombinations(expression);
            } while (ExpressionParser.CheckExpressionIsCompound(expression));

            var expressionTotal = CalculateExpression(expression);
            return expressionTotal;
        }

        private static string SimplifyExpression(string expression)
        {
            Dictionary<string, int> location = new Dictionary<string, int>() { { "index", 0 }, { "length", 0 } };
            var subexpression = ExpressionParser.GetExpressionWithMaxPriority(expression, ref location);
            var subexpressionResult = CalculateExpression(subexpression);

            if (location["length"] == 0 && location["index"] == 0)
            {
                location["length"] = expression.Length;
            }

            expression = expression.Remove(location["index"], location["length"])
                .Insert(location["index"], subexpressionResult.ToString());

            return expression;
        }

        private static double CalculateExpression(string simpleExpression)
        {
            var expressionMembers = ExpressionParser.ParseSimpleExpression(simpleExpression);
            if (expressionMembers.Keys.Count == 3)
            {
                var operand1 = double.Parse(expressionMembers["operand1"]);
                var operand2 = double.Parse(expressionMembers["operand2"]);
                var operationSymbol = expressionMembers["operation"];
                var operation = ResolveOperation(operand1, operand2, operationSymbol);
                return operation.Execute();
            }
            else
            {
                return Double.Parse(expressionMembers["operand1"]);
            }
        }

        private static Operation ResolveOperation(double operand1, double operand2, string symbol)
        {
            if (!GetAvailableOperationSymbols().Contains(symbol))
            {
                throw new Exception(message: $"The {symbol} operation is not supported");
            }
            else
            {
                Type operationType = GetAvailableOperations()
                    .FirstOrDefault(operation => operation.Value.Contains(symbol))
                    .Key;

                Operation operation = (Operation)Activator.CreateInstance(operationType, operand1, operand2);
                return operation;
            }
        }

        private static Dictionary<Type, string[]> GetAvailableOperations()
        {
            Dictionary<Type, string[]> availableOperations = new Dictionary<Type, string[]>();

            var listOfOperations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(domainAssembly => domainAssembly.GetTypes())
                .Where(type => type.IsSubclassOf(typeof(Operation))
                ).ToList();

            foreach (var operation in listOfOperations)
            {
                string[] availableOperationSymbols = (string[])(operation.GetField("OperationSymbols")?
                    .GetValue(null) ?? Array.Empty<string>());

                availableOperations.Add(operation, availableOperationSymbols);
            }

            return availableOperations;
        }

        private static List<string> GetAvailableOperationSymbols()
        {
            List<string> availableOperationSymbols = new List<string>();
            foreach (var symbolsArray in AvailableOperations.Values)
            {
                foreach (var symbol in symbolsArray)
                {
                    availableOperationSymbols.Add(symbol);
                }
            }

            return availableOperationSymbols;
        }

        public static void MemorizeOperation(string expression, double total, int id = -1)
        {
            if (Memory.Count == 5 && id != -1)
            {
                Memory.RemoveAt(0);
            }

            if (id == -1)
            {
                Memory.Add(new List<string>() { $"{expression}", $"{total.ToString()}" });
            }

            else if (id >= 0 && id < Memory.Count)
            {
                Memory[id] = new List<string>() { $"{expression}", $"{total.ToString()}" };
            }

            else
            {
                throw new Exception(message: "There is no such object in memory");
            }
        }
    }
}