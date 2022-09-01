using System;

namespace ClassWork
{
    public  class Calculator
    {
        public double Operand1 { get;}
        public double Operand2 { get;}
        public string Operation { get;}

        public Calculator(double operand1, double operand2, string operation)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operation = operation;
        }

        public  double Add() => Operand1 + Operand2;

        public  double Subtract() => Operand1 - Operand2;
        
        public   double Multiply() => Operand1 * Operand2;
        
        public   double Divide() => Operand1 / Operand2;

        public  double Power() => Math.Pow(Operand1, Operand2);

        public  double Root() => Math.Pow(Operand1, 1 / Operand2);

        public  double Percent() => Operand1 / 100 * Operand2;

        public  double Execute()
        {
            switch (Operation)
            {
                case "+":
                    return Add();
                case "-":
                    return Subtract();
                case "*":
                    return Multiply();
                case "/":
                    return Divide();
                case "^":
                    return Power();
                case "root":
                    return Root();
                case "%":
                    return Percent();
                default:
                    throw new Exception(message: $"Sorry, the {Operation} operation is not supported");
            }
        }
    }
}