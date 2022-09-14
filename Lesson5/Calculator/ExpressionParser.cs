using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    public static class ExpressionParser
    {
        public static string UserExpression { get; set; }

        public static string GetExpressionWithMaxPriority(string expression, ref Dictionary<string, int> location)
        {
            do
            {
                if (expression.Contains("(") && expression.Contains(")"))
                {
                    expression = GetExpressionInBrackets(expression, ref location); //11+7/-5-7
                    continue;
                }

                expression = GetFirstPriorityExpression(expression, ref location); // 7/-5
            } while (CheckExpressionIsCompound(expression));

            return expression;
        }

        internal static bool CheckExpressionIsCompound(string expression)
        {
            Regex pattern = new Regex(@"(?<operand>(?:\d+\.*\d*)+)");

            var qtyOperatorsFound = pattern.Matches(expression).Count;

            return qtyOperatorsFound > 2;
        }

        public static string GetRegexOrOperations() //TODO use parameters to limit operations
        {
            var availableOperations = Calculator.AvailableOperationSymbols.ToList();
            for (int i = 0; i < availableOperations.Count; i++)
            {
                availableOperations[i] = Regex.Escape(availableOperations[i]);
            }

            string symbolsOrPattern = string.Join("|", availableOperations);
            return symbolsOrPattern;
        }

        private static string GetExpressionInBrackets(string expression, ref Dictionary<string, int> location)
        {
            Regex pattern =
                new Regex(
                    @"\((?<bracketsExpression>-*?(?:\d\.*\d*)(?:\+|\/|mod|\*|x|%|pow|\^|root|-)*(?:-*?(?:\d\.*\d*)*)*)\)"); //\((?<bracketsExpression>(?!\().*?)\)

            Match expressionInBracketsFound = pattern.Match(expression);

            if (expressionInBracketsFound.Success)
            {
                GroupCollection groups = expressionInBracketsFound.Groups;
                location["index"] += groups["bracketsExpression"].Index - 1;
                location["length"] = groups["bracketsExpression"].Length + 2;

                expression = GetExpressionInBrackets(groups["bracketsExpression"].Value, ref location);
            }

            else if (!(expressionInBracketsFound.Success) && expression.Contains('('))
            {
                throw new Exception(message: "Expression in brackets is not valid");
            }

            return expression;
        }

        private static string GetFirstPriorityExpression(string expression, ref Dictionary<string, int> location)
        {
            Regex powerAndRootPattern =
                new Regex(@"(?<FirstPriority>(?:\d\.*\d*)+?(?:pow|root|\^)+?-*?(?:\d\.*\d*)+?)");
            //TODO Fetch symbols for power/root

            var powerOrRootFound = powerAndRootPattern.Match(expression);
            if (powerOrRootFound.Success)
            {
                GroupCollection groups = powerOrRootFound.Groups;
                location["index"] += groups["FirstPriority"].Index;
                location["length"] = groups["FirstPriority"].Length;
                expression = groups["FirstPriority"].Value;
            }
            else if (!powerOrRootFound.Success)
            {
                Regex multiplicationDivisionPattern =
                    new Regex(@"(?<FirstPriority>(?:\d\.*\d*)+?(?:\*|\/|\%|mod){1}-*?(?:\d\.*\d*)+?)");
                //TODO Fetch symbols for multiplication division percentage modulo

                var multiplicationOrDivisionFound = multiplicationDivisionPattern.Match(expression);
                if (multiplicationOrDivisionFound.Success)
                {
                    GroupCollection groups = multiplicationOrDivisionFound.Groups;
                    location["index"] += groups["FirstPriority"].Index;
                    location["length"] = groups["FirstPriority"].Length;
                    expression = groups["FirstPriority"].Value;
                }
            }

            else
            {
                Regex lastPriorityPattern =
                    new Regex(@"(?<FirstPriority>-*?(?:\d\.*\d*)+?(?:\+|-){1}-*?(?:\d\.*\d*)+?)");

                var lowPriorityOperationFound = lastPriorityPattern.Match(expression);
                if (lowPriorityOperationFound.Success)
                {
                    GroupCollection groups = lowPriorityOperationFound.Groups;
                    location["index"] += groups["FirstPriority"].Index;
                    location["length"] = groups["FirstPriority"].Length;
                    expression = groups["FirstPriority"].Value;
                }
            }

            return expression;
        }

        internal static Dictionary<string, string> ParseSimpleExpression(string simpleExpression)
        {
            var expressionMembers = new Dictionary<string, string>() { };

            Regex twoOperandsAndOperation =
                new Regex(@"(?<operand1>-*?(?:\d+\.*\d*)+)(?<operation>(?:" + GetRegexOrOperations() +
                          @")+?)(?<operand2>-*?(?:\d+\.*\d*)+)");
            //TODO Fetch symbols for multiplication division percentage modulo

            var twoOperandsAndOperationFound = twoOperandsAndOperation.Match(simpleExpression);
            if (twoOperandsAndOperationFound.Success)
            {
                GroupCollection groups = twoOperandsAndOperationFound.Groups;
                expressionMembers["operand1"] = groups["operand1"].Value;
                expressionMembers["operand2"] = groups["operand2"].Value;
                expressionMembers["operation"] = groups["operation"].Value;
                return expressionMembers;
            }
            else
            {
                Regex oneOperandAndOptionalSign =
                    new Regex(@"(?<operand>-*?(?:\d+\.*\d*)+)");

                var oneOperandFound = oneOperandAndOptionalSign.Match(simpleExpression);
                if (oneOperandFound.Success)
                {
                    GroupCollection groups = oneOperandFound.Groups;
                    expressionMembers["operand1"] = groups["operand"].Value;
                    return expressionMembers;
                }
                else
                {
                    throw new Exception(message: $"Invalid Expression: {simpleExpression}");
                }
            }
        }
    }
}