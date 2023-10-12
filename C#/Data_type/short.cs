using System;
namespace short_type
{
    class Short
    {
        public static void Main()
        {
            short s; // (2 byte) Range -32,768 to 32,767 (allows negative as well as positive values) 
            Console.Write("Enter short value: ");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Short value: " + s);
            Console.ReadKey();
        }
    }
}