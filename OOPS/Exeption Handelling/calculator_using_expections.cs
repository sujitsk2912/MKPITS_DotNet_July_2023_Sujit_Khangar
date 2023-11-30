using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_using_expections
{
    class Calculator
    {
        public decimal num1;
        public decimal num2;
        public decimal res = 0;

        public void Addition(decimal num1,decimal num2)
        {
            res = num1 + num2;
        }
        public void Substraction(decimal num1, decimal num2)
        {
            res = num1 - num2;
        }
        public void Multiplication(decimal num1, decimal num2)
        {
            res = num1 * num2;

        }
        public void Division(decimal num1, decimal num2)
        {
            res = num1 / num2;
        }

        public void DisplayResult()
        {
            Console.WriteLine("\nResult: " + res);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1;
            decimal n2;
            char op;

            Calculator c = new Calculator();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    n1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    n2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter Operator ( + - * / ): ");
                    op = Convert.ToChar(Console.ReadLine());

                    if (op == '+')
                    {
                        c.Addition(n1, n2);
                    }

                    else if (op == '-')
                    {
                        c.Substraction(n1, n2);
                    }

                    else if (op == '*')
                    {
                        c.Multiplication(n1, n2);
                    }

                    else if (op == '/')
                    {
                        c.Division(n1, n2);
                    }

                    else
                    {
                        throw new Exception("Invalid Operator, please enter correct....");
                    }

                    c.DisplayResult();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
                finally
                {
                   Console.WriteLine("\nPress Enter\n");
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
