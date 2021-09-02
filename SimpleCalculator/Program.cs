using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args) {
            SimpleCalculator();
        }
        static void SimpleCalculator() {
            try
            {
                int a = AskForANumber();
                char op = AskForAnOperation();
                int b = AskForANumber();
                Console.WriteLine($"The result is {Calculate(op, a, b)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Message : {e.Message}");
            }
        }
          
        private static int AskForANumber() {
            Console.WriteLine("Please provide a number!");
            var numberString = Console.ReadLine();
            int number;
            bool parseSucces = int.TryParse(numberString, out number);
            if (parseSucces)
            {
                return number;
            }
            else
            {
                throw new FormatException("Invalid value. Must be a number!");
            }
        }
       
        private static char AskForAnOperation() {
            Console.WriteLine("Please provide an operator (one of +, -, *, /)! ");
            var oper = char.Parse(Console.ReadLine());
            return oper;
        }
        private static int Calculate(char op, int a, int b) {
            int result = 0;
            switch (op) {
                case '+': {
                        result = a + b;
                        break;
                    }
                case '-':
                    {
                        result = a - b;
                        break;
                    }
                case '*':
                    {
                        result = a * b;
                        break;
                    }
                case '/':
                    {
                        if (b != 0)
                        {
                            result = a / b;
                        }
                        else
                        {
                            Console.WriteLine("'Error: Division by zero");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;

            }
            return result;
        }
            
    }
}
