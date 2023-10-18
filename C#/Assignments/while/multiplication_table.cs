using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i = 1;
            int j = 1;

            Console.Write("Input up to the table number starting from 1: ");
             num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication table from 1 to " + num + "\n");

            while (i <= 10)
            {
                j = 1;
                while (j <= num)
                {
                    int result = i * j;
                    Console.Write("{0}x{1}={2} ", j, i, result);
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
