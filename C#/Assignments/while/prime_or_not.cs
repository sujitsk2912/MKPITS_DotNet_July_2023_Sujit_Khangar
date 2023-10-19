using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, counter, rem = 0;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for( counter = 2; counter < num; counter++ )
            {
                if( num % counter == 0 )
                {
                    rem = 1;
                    break;
                }
            }

            if( rem == 0 )
            {
                Console.WriteLine("\n{0} is prime",num );
            }
            else
            {
                Console.WriteLine("\n{0} is not prime", num);
            }

            Console.ReadKey();
        }
            
    }
}
