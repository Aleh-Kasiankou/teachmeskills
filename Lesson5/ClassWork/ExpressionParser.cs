using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassWork
{
    public static class ExpressionParser
    {
        private static string UserExpression { get; set; }

        internal static string ValidateExpression(string rawExpression, out string newExpressionBase, ref bool isComplete, string expressionBase)
        {
            var validationStringBuilder =
                new StringBuilder(String.IsNullOrWhiteSpace(expressionBase) ? "" : expressionBase);

            if (rawExpression.Count(x => x == '=') > 0 && !rawExpression.Trim().EndsWith('=') )
            {
                throw new Exception(message: "Sorry, there should be only one equal sign in the last position");
            }

            isComplete = rawExpression.Trim()[^1] == '=';
            var insertedOperator = new List<char>();

            foreach (char expressionChar in rawExpression)
            {
                var tempOperator = String.Join("", insertedOperator);
                if (insertedOperator.Count > 0 && (Char.IsDigit(expressionChar)||expressionChar=='.'))
                {
                    if (Calculator.AvailableOperationSymbols.Any(x => x == tempOperator))
                    {
                        validationStringBuilder.Append(tempOperator);
                        insertedOperator.Clear();
                    }

                    else
                    {
                        throw new Exception(message: $"Unsupported operator {tempOperator}");
                    }

                }

                if (expressionChar == ' ' || expressionChar == '=')
                {
                    //DoNothing
                }

                else if(char.IsDigit(expressionChar) || expressionChar == '(' ||expressionChar == ')')
                {
                    validationStringBuilder.Append(expressionChar);
                }
                
                else if (expressionChar == '.')
                {
                    if (Char.IsDigit(validationStringBuilder[^1]))
                    {
                        validationStringBuilder.Append(expressionChar);
                    }

                    else
                    {
                        throw new Exception(message: "Dots are only available as separators for fractions");
                    }
                }
                
                else if (!Char.IsDigit(expressionChar)) //check for allowed operators
                {
                    if (Calculator.AvailableOperationSymbols.Any(x => x.Contains(tempOperator + expressionChar)))
                    {
                        insertedOperator.Add(expressionChar);
                    }
                    else
                    {
                        throw new Exception(message: $"Unsupported operator {String.Join("", insertedOperator) + expressionChar}");
                    }
                }
                
            }

            var expression = validationStringBuilder.ToString();
            
            if (isComplete && expression.Count(x => x == '(') != expression.Count(x => x == ')'))
            {
                throw new Exception(message: "Sorry, you should check the number of brackets");
            }
            
            expression = ResolveSymbolCombinations(expression);
            if (isComplete)
            {
                UserExpression = expression;
                newExpressionBase = String.Empty;
            }

            else
            {
                newExpressionBase = expression;
            }
            
            return expression;
        }

        internal static string ResolveSymbolCombinations(string rawExpression)
        {
            string symbolsOrPattern = GetRegexOrOperations();
            string expression = rawExpression;

            Regex pattern = new Regex(@"(?<twosymbols>(?:" + symbolsOrPattern + "){2})");

            MatchCollection matches = pattern.Matches(expression);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;

                var twoSymbols = groups["twosymbols"].Value;
                if (twoSymbols[0] == twoSymbols[1])
                {
                    expression = expression.Replace(twoSymbols,
                        twoSymbols.Contains("-") ? "" : twoSymbols[0].ToString()); //replace with Regex.Replace
                }
                else if (twoSymbols.Contains("-") && twoSymbols.Contains("+"))
                {
                    expression = expression.Replace(twoSymbols, "-");
                }
                else if (twoSymbols[1] == '-' && (char.IsDigit(expression[groups["twosymbols"]
                             .Index - groups["twosymbols"].Length + 1])))
                {
                    //ignore since this is an operation with negative number
                }

                else
                {
                    throw new Exception(message:
                        $"Only + and - can be placed together. You placed {twoSymbols} here " +
                        $"{expression.Substring(groups["twosymbols"].Index - groups["twosymbols"].Length - 1)}");
                }
            }

            return expression;
        }

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

        private static string GetRegexOrOperations() //TODO use parameters to limit operations
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