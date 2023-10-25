using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_to_prime_or_not_with_single_parameter
{
    internal class Program
    {
        static int cheak(int n)
        {
            int counter = 1;
            for (counter = 1; counter <= n; counter++)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine("Number is prime");
                    break;
                }
                else
                {
                    Console.WriteLine("Number is Not Prime");
                    break;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int result = cheak(num);

            Console.ReadKey();
        }
    }
}
