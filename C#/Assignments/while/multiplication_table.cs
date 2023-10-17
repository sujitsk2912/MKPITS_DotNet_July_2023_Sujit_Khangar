using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input up to the table number starting from 1: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication table from 1 to " + n  + "\n");

            int i = 1; 
            while (i <= 10) 
            {
                int j = 1; 
                while (j <= n) 
                {
                    int result = i * j;
                    Console.Write("{0}x{1} = {2}",j,i,result);

                    if (j != n)
                    {
                        Console.Write(", ");
                    }
                    j++; 
                }
                Console.WriteLine(); 
                i++;
            }
            Console.ReadKey();
        }
    }
}
