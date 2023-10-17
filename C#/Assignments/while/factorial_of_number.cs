using System;
namespace FACTORIAL
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, fact = 1;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("\nfactorial: " + fact);
            Console.ReadKey();
        }
    }
}           