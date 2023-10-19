using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args) 
        {
            int num, fact = 1, counter = 1;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter = num; counter >0; counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("factorial: {0}",fact);
            Console.ReadKey();
        }
    }
}