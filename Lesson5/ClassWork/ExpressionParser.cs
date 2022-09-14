using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassWork
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
        // ()
        // Root / pow
        // * / % mod

        internal static bool CheckExpressionIsCompound(string expression) //positive and negative numbers check
        {
            // Regex pattern = new Regex(@"(?<operationsymbols>(?:\d|\))+?(?:" + symbolsOrPattern + "))");
            Regex pattern = new Regex(@"(?<operand>(?:\d+\.*\d*)+)");

            bool isHasMultipleOperations = pattern.Matches(expression).Count > 1;
            return pattern.Matches(expression).Count > 2; //([0-9]+?(?:\+|/|mod|\*|x|%|pow|\^|root|-))
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
            Regex pattern = new Regex(@"\((?<bracketsExpression>-*?(?:\d\.*\d*)(?:\+|\/|mod|\*|x|%|pow|\^|root|-)*(?:-*?(?:\d\.*\d*)*)*)\)"); //\((?<bracketsExpression>(?!\().*?)\)

            MatchCollection matches = pattern.Matches(expression);

            if (matches.Count > 0)
            {
                GroupCollection groups = matches[0].Groups;
                location["index"] += groups["bracketsExpression"].Index - 1;
                location["length"] = groups["bracketsExpression"].Length + 2;

                expression = GetExpressionInBrackets(groups["bracketsExpression"].Value, ref location);
            }

            else if(matches.Count == 0 && expression.Contains('('))
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
            //TODO improve work with negative numbers

            MatchCollection matches = powerAndRootPattern.Matches(expression);
            if (matches.Count > 0)
            {
                GroupCollection groups = matches[0].Groups;
                location["index"] += groups["FirstPriority"].Index;
                location["length"] = groups["FirstPriority"].Length;
                expression = groups["FirstPriority"].Value;
            }
            else if (matches.Count == 0)
            {
                Regex multiplicationDivisionPattern =
                    new Regex(@"(?<FirstPriority>(?:\d\.*\d*)+?(?:\*|\/|\%|mod){1}-*?(?:\d\.*\d*)+?)");
                //TODO Fetch symbols for multiplication division percentage modulo

                matches = multiplicationDivisionPattern.Matches(expression);
                if (matches.Count > 0)
                {
                    GroupCollection groups = matches[0].Groups;
                    location["index"] += groups["FirstPriority"].Index;
                    location["length"] = groups["FirstPriority"].Length;
                    expression = groups["FirstPriority"].Value;
                }
            }

            if (matches.Count == 0)
            {
                Regex lastPriorityPattern =
                    new Regex(@"(?<FirstPriority>-*?(?:\d\.*\d*)+?(?:\+|-){1}-*?(?:\d\.*\d*)+?)");
                //TODO Fetch symbols for multiplication division percentage modulo

                matches = lastPriorityPattern.Matches(expression);
                if (matches.Count > 0)
                {
                    GroupCollection groups = matches[0].Groups;
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

            var matches = twoOperandsAndOperation.Matches(simpleExpression);
            if (matches.Count > 0)
            {
                GroupCollection groups = matches[0].Groups;
                expressionMembers["operand1"] = groups["operand1"].Value;
                expressionMembers["operand2"] = groups["operand2"].Value;
                expressionMembers["operation"] = groups["operation"].Value;
                return expressionMembers;
            }
            else
            {
                Regex operandAndOptionalSign =
                    new Regex(@"(?<operand>-*?(?:\d+\.*\d*)+)");

                matches = operandAndOptionalSign.Matches(simpleExpression);
                if (matches.Count == 1)
                {
                    GroupCollection groups = matches[0].Groups;
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