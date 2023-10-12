using System;
namespace multiplication3
{
    class multiplication
    {
        static void Main()
        {
            int num1, num2, num3, mul;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            mul = num1 * num2 * num3;
            Console.WriteLine("Mutiplication: " + mul);
            Console.ReadKey();
        }
    }
}