using System;
namespace UINT
{
    class UInt
    {
        public static void Main()
        {
            uint ui; // (4 byte) Range 0 to 4,294,967,295 ( it contains only positive values)
            Console.Write("Enter UInt value: ");
            ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("UInt value: " + ui);
            Console.ReadKey();
        }
    }
}