using System;
namespace LEAPYEAR
{
    class leapyear
    {
        public static void Main(string[] args)
        {
            int year;
            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year%4 == 0 )
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
            Console.ReadKey();  
        }
    }
}