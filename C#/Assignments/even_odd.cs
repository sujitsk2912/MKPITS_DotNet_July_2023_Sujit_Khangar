using System;
namespace EVENODD
{
    class Evenodd
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0) 
            {
                Console.WriteLine("Number are Even");
            }
            else
            {
                Console.WriteLine("Number are Odd");
            }
            Console.ReadKey();
        }
    }
}