using System;
namespace consoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 5, counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;

            }
            while (counter <= num);
            Console.ReadKey();
        }
    }
}