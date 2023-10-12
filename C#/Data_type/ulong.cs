using System;
namespace ULONG
{
    class ULong
    {
        public static void Main()
        {
            ulong ul; // (8 byte) Range 0 to 18,446,744,073,709,551,615 ( it contains only positive values)
            Console.WriteLine("Enter ULong value: ");
            ul = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("ULong value: " + ul);
            Console.ReadKey();
        }
    }
}