using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, counter = 1;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter = 1; counter <= num; counter++)
            {
                if(num % 2 == 1)
                {
                    Console.WriteLine("{0} is prime no", num);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is not prime no",num);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}