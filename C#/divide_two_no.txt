using System;
namespace dividing
{
    class divide
    {
        static void Main()
        {
            float num1, num2, divide;
            Console.WriteLine("Enter Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            divide = num1 / num2;
            Console.WriteLine("Divide: " + divide);
            Console.ReadKey();
        }
    }
}