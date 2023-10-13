using System;
namespace GREATER_NO
{
    class Greater_no
    {
        public static void Main()
        {
            int num1, num2;

            Console.Write("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            if (num1 > num2)
            {
                Console.WriteLine("Num1 is Greater");
            }
            else
            {
                Console.WriteLine("Num2 is Greater");
            }

            Console.ReadKey();
        }
    }
}