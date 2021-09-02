using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
        }
        static void SimpleCalculator()
        {
                int a = AskForANumber();
                char op = AskForAnOperation();
                int b = AskForANumber();
                Console.WriteLine($"The result is {Calculate(op, a, b)}");
        }
          
        private static int AskForANumber()
        {
            throw new NotImplementedException();
        }
        private static char AskForAnOperation()
        {
            throw new NotImplementedException();
        }
        private static int Calculate(char op, int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
