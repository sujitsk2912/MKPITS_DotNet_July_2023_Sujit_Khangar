using System;
namespace squreprogram
{
    class squre
    {
        static void Main()
        {
            int num, squre;
            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            squre = num*num;
            Console.WriteLine("Squre: " +  squre);
            Console.ReadKey();
        }
    }
}