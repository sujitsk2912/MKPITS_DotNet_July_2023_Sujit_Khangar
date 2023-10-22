using System;
namespace WHILE_LOOP
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int sum =0;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter = num; counter <= num; counter++ )
            {
                Console.WriteLine();
                for(counter = 1; counter <= num; counter++ )
                {
                    Console.WriteLine(counter);
                    sum = sum + counter;
                }
            }
            Console.WriteLine("\nSum of numbers: {0}", sum);
            Console.ReadKey();
        }
    }
}