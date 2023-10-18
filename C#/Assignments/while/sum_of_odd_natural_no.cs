using System;
namespace ODD
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, counter = 1, sum = 0;
            Console.Write("Enter number of terms: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe odd numbers are: ");

            while( counter <= num )
            {
                Console.WriteLine("{0} ", 2 * counter - 1);
                sum += 2 * counter - 1; 
                counter++;
            }
            Console.WriteLine("\n\nThe Sum of odd Natural Number are: {0}", sum);
            Console.ReadKey();
        }
    }
}