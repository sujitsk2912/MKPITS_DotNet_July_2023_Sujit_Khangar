using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returning_value
{
    internal class Program
    {
        static int Factorial(int num)
        {
            int fact = 1;
            while ( num > 0 )
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int number, result;
            Console.Write("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            result = Factorial(number);

            Console.WriteLine("Factorial: " + result);
            Console.ReadKey();
            
        }
    }
}
