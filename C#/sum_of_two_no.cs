using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_to_print_sum_of_two_no
{
    internal class Program
    {
        static int Addition(int n1, int n2)
        {
            int sum;
            sum = n1 + n2;
            return sum;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = Addition(num1, num2);
            
            Console.WriteLine("\nSum of two numbers is: " + result);
            Console.ReadKey();

        }
    }
}
