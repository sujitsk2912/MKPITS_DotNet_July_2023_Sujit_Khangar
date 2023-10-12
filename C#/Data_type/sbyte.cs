using System;
namespace SignByte
{
    class SByte
    {
        public static void Main()
        {
            sbyte sb; // Range -128 to 127 ( it contains negative as well as positive values)
            Console.Write("Enter SByte: ");
            sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("SByte value: " + sb);
            Console.ReadKey();
        }
    }
}