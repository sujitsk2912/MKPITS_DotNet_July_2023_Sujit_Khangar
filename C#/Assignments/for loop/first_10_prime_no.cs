using System;
namespace WHILE_LOOP
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 10;
            int counter = 1;
            Console.WriteLine("First 10 prime numbers are \n");

            for(counter =1; counter <= num; counter++ )
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}