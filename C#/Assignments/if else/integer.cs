using System;
namespace Integer
{
    class integer
    {
        public static void Main(string[] args)
        {
            int m;
            Console.Write("Enter Number: ");
            m = Convert.ToInt32(Console.ReadLine());

            if(m>0)
            {
                Console.WriteLine("The value of n: 1");
            }
            else
            {
                Console.WriteLine("The value of n: -1");
            }

            Console.ReadKey();
        }
    }
}