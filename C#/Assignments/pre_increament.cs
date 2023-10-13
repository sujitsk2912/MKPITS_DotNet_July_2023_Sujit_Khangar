using System;
namespace APTITUDE
{
    class pre
    {
        public static void Main()
        {
            int i = 0;
            int j = ++i;  // ++i ( pre - increament) 
            Console.WriteLine("value of i: " + i);
            Console.WriteLine("value of j: " + j);
            Console.ReadKey();
        }
    }
}