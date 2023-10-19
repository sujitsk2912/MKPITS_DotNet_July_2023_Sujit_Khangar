using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args) 
        {
            int num, num1, sum = 0, counter;
            Console.Write("Enter Range: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter numbers: ");
            for ( counter = 1; counter <= num; counter++)
            {
                if(counter <= num)
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    sum = sum + num1;
                }
            }
            Console.WriteLine("\nsum of {0} no. is {1}",num, sum);
            Console.ReadKey();
        }
    }
}