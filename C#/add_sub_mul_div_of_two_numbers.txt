using System;
namespace operators
{
    class addnum
    {
        static void Main()
        {
            float num1, num2, add, mul, sub,div;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            Console.WriteLine("");
            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Substraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.ReadKey();
        }
    }
}