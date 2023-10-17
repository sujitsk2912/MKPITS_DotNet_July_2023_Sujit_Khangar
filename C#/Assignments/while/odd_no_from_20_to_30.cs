using System;
namespace ODD
{
    class program
    {
        public static void Main(string[] args)
        {
            int counter = 20;

            while (counter <= 30)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(counter + " is Odd");
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}