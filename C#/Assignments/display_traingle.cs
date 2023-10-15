using System;

namespace DisplayReverseTriangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number, width;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
