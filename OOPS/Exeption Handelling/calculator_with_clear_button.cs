using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_with_clear_button
{
    class Calculator
    {
        public decimal num1;
        public decimal num2;
        public decimal res = 0;

        public void Add(decimal num1, decimal num2)
        {
            res = num1 + num2;
        }
        public void Substract(decimal num1, decimal num2)
        {
            res = num1 - num2;
        }
        public void Multiply(decimal num1, decimal num2)
        {
            res = num1 * num2;
        }
        public void Divide(decimal num1, decimal num2)
        {
            res = num1 / num2;
        }
        public void Clear()
        {
            res = 0;
        }

        public void DisplayResult()
        {
            Console.WriteLine("\nResult: " +  res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1;
            decimal n2;
            string Op = null;

            Calculator c = new Calculator();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    n1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    n2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter Operator ( + - * / ) or 'cr' for clear result :");
                    Op = Console.ReadLine();

                    if (Op == "+")
                    {
                        c.Add(n1, n2);
                    }

                    else if (Op == "-")
                    {
                        c.Substract(n1, n2);
                    }

                    else if (Op == "*")
                    {
                        c.Multiply(n1, n2);
                    }

                    else if (Op == "/")
                    {
                        c.Divide(n1, n2);
                    }

                    else if (Op == "cr")
                    {
                        c.Clear();
                    }

                    else
                    {
                        throw new Exception("Invalid Operator, please enter correct...");
                    }

                    c.DisplayResult();

                }

                catch(Exception ex) 
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
