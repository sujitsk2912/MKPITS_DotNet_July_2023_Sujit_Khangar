using System;
namespace WHILE_LOOP
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 10;
            int counter = 1;
            int sum =0;
            Console.WriteLine("First 10 prime numbers are \n");

            for(counter =1; counter <= num; counter++ )
            {
                Console.WriteLine(counter);
                sum = sum + counter;
            }
            Console.WriteLine("\nSum of numbers: {0}", sum);
            Console.ReadKey();
        }
    }
}