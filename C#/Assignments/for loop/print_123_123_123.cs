using System;
namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int row = 1, col = 1;

            for (row = 1; row <= 3; row++)
            {
                for (col = 1; col <= 3; col++)
                {
                    Console.Write(col + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}