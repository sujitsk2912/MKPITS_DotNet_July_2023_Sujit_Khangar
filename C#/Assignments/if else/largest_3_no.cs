using System;
namespace LARGEST_NO
{
    class LARGEST_NO
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
                Console.WriteLine("The 1st Number is the greatest among three");
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }

            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }

            Console.ReadKey();

        }
    }
}