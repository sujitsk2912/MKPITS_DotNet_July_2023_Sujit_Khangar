using System;
namespace EVEN
{
    class program
    {
        public static void Main(string[] args)
        {
            int counter = 2;

            while(counter <= 10)
            {
                if(counter % 2 == 0)
                {
                    Console.WriteLine(counter + " is even");
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}