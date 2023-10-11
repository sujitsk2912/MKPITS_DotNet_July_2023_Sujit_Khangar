using System;
namespace swapping
{
    class swap
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("");
            Console.WriteLine("After Swapping");
            Console.WriteLine("--------------------");
            Console.WriteLine("First number: " + a);
            Console.WriteLine("Second number: " + b);
            Console.ReadKey();
        }
    }
}