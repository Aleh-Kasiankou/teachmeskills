using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public static class Validator
    {
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
                ExpressionParser.UserExpression = expression;
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
            string symbolsOrPattern = ExpressionParser.GetRegexOrOperations();
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
    }
}