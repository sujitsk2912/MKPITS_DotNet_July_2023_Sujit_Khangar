using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence_using_method
{
    internal class Program
    {
        static int fibonacci(int n, int n1, int n2)
        {
            int cnt = 0; // Initialize cnt to 0
            int add;

            for (cnt = 0; cnt < n; cnt++)
            {
                if (cnt < 2)
                {
                    add = cnt; // print (0 and 1) first
                }
                else
                {
                    add = n1 + n2;
                    n1 = n2;
                    n2 = add;
                }
                Console.WriteLine(add);
            }
            return n;
        }

        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 1;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int result = fibonacci(num, num1, num2);
           
            Console.ReadKey();

        }
    }
}
