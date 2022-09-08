using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorApp.Operations;

namespace ClassWork
{
    public static class Calculator
    {
        public static readonly string[] Memory;
        public static double CurrentResult = 0;

        private static readonly Dictionary<Type, string[]> AvailableOperations = GetAvailableOperations();
        public static readonly List<string> AvailableOperationSymbols = GetAvailableOperationSymbols();

        private static double CalculateExpression(string simpleExpression)
        {
            var expressionMembers = ExpressionParser.ParseSimpleExpression(simpleExpression);
            var operand1 = double.Parse(expressionMembers["operand1"]);
            var operand2 = double.Parse(expressionMembers["operand2"]);
            var operationSymbol = expressionMembers["operation"];
            var operation = ResolveOperation(operand1, operand2, operationSymbol);
            return operation.Execute();
        }

        public static double Calculate(string expression)
        {
            while (ExpressionParser.CheckExpressionIsCompound(expression))
            {
                Dictionary<string, int> Location = new Dictionary<string, int>() { { "index", 0 }, { "length", 0 } };
                var subexpression = ExpressionParser.GetExpressionWithMaxPriority(expression, ref Location);
                var subexpressionResult = CalculateExpression(subexpression);
                //TODO Move to a separate ExpressionParser method
                
                expression = expression.Remove(Location["index"], Location["length"])
                    .Insert(Location["index"], subexpressionResult.ToString());
            }

            var expressionTotal = CalculateExpression(expression);
            return expressionTotal;

        }

        private static IOperation ResolveOperation(double operand1, double operand2, string symbol)
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
    }
}