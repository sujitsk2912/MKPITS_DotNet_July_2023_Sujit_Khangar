using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_with_3_parameters
{
    internal class Program
    {
        static int Calculate(int n1, int n2, char OP)
        {
            int res = 0;

            if( OP == '+' )
            {
                res = n1 + n2;
            }
            else if (OP == '-')
            {
                res = n1 - n2;
            }
            else if (OP == '*')
            {
                res = n1 * n2;
            }
            else
            {
                Console.WriteLine("Inavlid Operator");
            }

            return res;

        }
        static void Main(string[] args)
        {
            int num1, num2, result;
            char op;

            Console.Write("Enter Number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operator ( + - * ): ");
            op = Convert.ToChar(Console.ReadLine());

            result = Calculate(num1, num2, op);

            Console.WriteLine("Result: " + result);
            Console.ReadKey();


        }
    }
}
