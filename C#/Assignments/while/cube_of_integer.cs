using System;

namespace CubeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1, counter = 1, cube = 0;

            Console.Write("Enter the number of terms: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (counter <= num)
            {
                Console.Write("Enter a number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                cube = num1 * num1 * num1;
                Console.WriteLine("Number is: {0} and cube of {0} is: {1}", num1, cube);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
