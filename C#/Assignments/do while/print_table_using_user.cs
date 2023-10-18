using System;
namespace SQUARE
{
    class program
    {
        public static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("enter limit");
            flag = Convert.ToInt32(Console.ReadLine()); 
            int i = 1;
            int j = 1;

            do
            {
                j = 1;
                while (j <= flag)
                {

                    Console.Write("{0}*{1}={2}", i, j, (j * i));
                    Console.Write("\t");

                    j++;

                }
                i++;
                Console.WriteLine();
            }
            while (i <= 10);

            Console.ReadKey();

        }
    }
}
