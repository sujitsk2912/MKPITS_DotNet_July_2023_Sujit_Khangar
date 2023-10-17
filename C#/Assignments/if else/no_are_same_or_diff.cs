using System;
namespace Compair
{
    class Equal
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2= Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else 
            {
                Console.WriteLine("Both numbers are different");
            }

            Console.ReadKey();
        }
    }
}