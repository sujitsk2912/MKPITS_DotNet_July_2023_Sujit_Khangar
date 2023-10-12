using System;
namespace REVERSE
{
    class Reverse
    {
        public static void Main()
        {
            char a, b, c;
            Console.Write("Enter first letter: ");
            a = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second letter: ");
            b = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter third letter: ");
            c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("----------------");
            Console.WriteLine("Reverse Oreder : " + c + " " + b + " "+ a);
            Console.ReadKey();
        }
    }
}