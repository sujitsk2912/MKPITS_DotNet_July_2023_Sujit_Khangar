using System;
namespace CHAR
{
    class Char
    {
        public static void Main()
        {
            char ch; // (2 byte) Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)
            Console.Write("Enter Char value: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char : " + ch);
            Console.ReadKey();
        }
    }
}