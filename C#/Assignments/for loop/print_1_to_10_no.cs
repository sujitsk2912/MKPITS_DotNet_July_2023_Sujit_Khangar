using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args) 
        {
            int num=10, counter = 1;

            Console.WriteLine("print 1 to 10 using for loop\n");

            for (counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}