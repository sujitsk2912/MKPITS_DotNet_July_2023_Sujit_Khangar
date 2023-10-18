using System;
namespace SQUARE
{
    class program
    {
        public static void Main(string[] args)
        {
            int i = 1, j = 2;
            int res1, res2;
            int counter = 1;
            do
            {
                res1 = i * counter;
                res2 = j * counter;
                Console.Write("{0}*{1}={2}", i, counter, res1);
                Console.Write("\t");
                Console.Write("{0}*{1}={2}", j, counter, res2);

                counter++;
                Console.WriteLine();
            }
            while (counter <= 10);

            Console.ReadKey();

        }
    }
}
