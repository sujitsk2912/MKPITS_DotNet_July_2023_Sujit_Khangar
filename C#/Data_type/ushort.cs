using System;
namespace ushort_type
{
    class UShort
    {
        public static void Main()
        {
            ushort us; // (2 byte) Range 0 to 65,535 (allows only positive values)
            Console.Write("Enter UShort value: ");
            us = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("UShort value: " + us);
            Console.ReadKey();
        }
    }
}