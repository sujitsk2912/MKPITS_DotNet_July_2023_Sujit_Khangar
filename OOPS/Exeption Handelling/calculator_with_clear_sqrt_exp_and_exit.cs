using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_with_clear_sqrt_exp_and_exit
{
    class Calculator
    {
        public decimal num1;
        public decimal num2;
        public decimal res = 0;

        public void Add(decimal num1,  decimal num2)
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

       /* public void Exponent(decimal num1, decimal num2)
        {
             
        }*/

       /* public void Sqrrt(decimal num1, decimal num2)
        {

        }*/

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
            int Op;

            Calculator c = new Calculator();

            Console.WriteLine("Select Number to be Calculated");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exponentiate");
            Console.WriteLine("6. Square Root");
            Console.WriteLine("7. Clear");
            Console.WriteLine("0. Exit");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    n1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    n2 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Select Operator value: ");
                    Op = Convert.ToInt32(Console.ReadLine());

                    if (Op == 1)
                    {
                        c.Add(n1, n2);
                    }

                    else if(Op == 2)
                    {
                        c.Substract(n1, n2);
                    }

                    else if (Op == 3)
                    {
                        c.Multiply(n1, n2);
                    }

                    else if (Op == 4)
                    {
                        c.Divide(n1, n2);
                    }

                    /*else if (Op == 5)
                    {
                        Console.WriteLine("Enter Base value: ");
                        decimal b = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Exponent value: ");
                        decimal n = Convert.ToDecimal(Console.ReadLine());

                        c.Exponent(b,n);
                    }*/

                    /*else if (Op == 6)
                    {
                        Console.WriteLine("Enter Number to be Squre Root: ");
                        decimal sq = Convert.ToDecimal(Console.ReadLine());

                        void Sqrt()
                        {
                            
                        }
                    }*/

                    else if (Op == 7)
                    {
                        c.Clear();
                    }

                    else if (Op == 0)
                    {
                        Console.WriteLine("Bye...");
                        Environment.Exit(0);
                    }

                    else
                    {
                        throw new Exception("Invalid value Please Select correct one...");
                    }

                    c.DisplayResult();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                finally
                {
                    Console.WriteLine("\nPress enter\n");
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
