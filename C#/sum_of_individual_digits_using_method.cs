using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_individual_digits
{
    internal class Program
    {
        static int Digits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Digits: ");
            num = Convert.ToInt32(Console.ReadLine());

            int result = Digits(num);
            Console.WriteLine("\nThe sum of the digits of the number " + num + " is : " + result);
            Console.ReadKey();
        }
    }
}
