using System;
namespace WHILE_LOOP
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            int counter = 10;

            while(counter >= num)
            {
                Console.WriteLine(counter);
                counter--;
            }
            Console.ReadKey();
        }
    }
}