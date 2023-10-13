using System;
namespace GREATER_NO
{
    class greater_no
    {
        public static void Main()
        {
            int num1, num2, num3;
            Console.Write("Enter Num1: ");
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(num1 > num2 && num1 > num3) 
            {
                Console.WriteLine("Num1 is Greater");
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is Greater");
            }

            else
            {
                Console.WriteLine("Num3 is Greater");
            }

            Console.ReadKey();

        }
    }
}