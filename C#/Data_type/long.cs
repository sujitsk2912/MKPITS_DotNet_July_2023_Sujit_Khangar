using System;
namespace LONG
{
    class Long
    {
        public static void Main()
        {
            long l; // (8 byte) Range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 ( it contains negative as well as positive values)
            Console.WriteLine("Enter Long value: ");
            l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Long value: " + l);
            Console.ReadKey();
        }
    }
}