using System;
namespace DECIMAL
{
    class Decimal
    {
        public static void Main()
        {
            decimal d; // (16 byte decibles ) Range (+ or -)1.0 x 10e-28 to 7.9 x 10e28
            Console.Write("Enter decimal value: ");
            d = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Decimal value: " + d);
            Console.ReadKey();
        }
    }
}