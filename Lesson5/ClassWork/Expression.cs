using System;

namespace ClassWork
{
    public class Expression
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public string Operation { get; set; }

        public Expression(string userInput)
        {
            try
            {
                var members = userInput?.Split(); // 5 + 6
                Operand1 = int.Parse(members[0]);
                Operand2 = int.Parse(members[2]);
                Operation = members[1];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}