using System;
namespace OPERATOR
{
    class program
    {
        public static void Main(string[] args)
        {
            float num1, num2, result = 0;
            char op;

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Operator ( +, -, *, / ): ");
            op = Convert.ToChar(Console.ReadLine());

            if( op == '+' )
            {
                result = num1 + num2;
            }

            else if (op == '-')
            {
                result = num1 - num2;
            }

            else if (op == '*')
            {
                result = num1 * num2;
            }

            else if (op == '/')
            {
                result = num1 / num2;
            }

            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();

        }
    }
}