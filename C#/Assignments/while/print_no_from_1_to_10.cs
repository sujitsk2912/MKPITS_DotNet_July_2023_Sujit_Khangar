using System;
namespace WHILE_LOOP
{
    class program
    {
        public static void Main(string[] args)
        {
            int counter=1;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}