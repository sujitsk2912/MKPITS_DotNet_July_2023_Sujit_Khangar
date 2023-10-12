using System;
namespace Byte
{
    class Byte
    {
        public static void Main()
        {
            byte b; // Range 0 to 255 ( negative value does not exist) 
            Console.Write("Enter Byte: ");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte value: " + b);
            Console.ReadKey();
        }
    }
}