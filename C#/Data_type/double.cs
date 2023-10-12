using System;
namespace DOUBLE
{
    class Double
    {
        public static void Main()
        {
            double d; // (8 byte decibles ) Range -1.79769313486232e308 to 1.79769313486232e308 
            Console.Write("Enter double value: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double value: " + d);
            Console.ReadKey();

        }
    }
}