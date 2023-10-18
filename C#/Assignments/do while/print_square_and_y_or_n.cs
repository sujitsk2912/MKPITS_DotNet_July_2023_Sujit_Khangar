using System;
namespace SQUARE
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, squre;
            char ch = 'y';

            do
            {
                Console.Write("\nEnter Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                squre = num * num;
                Console.WriteLine("\nSqure of {0} is: {1} ",num, squre);

                Console.Write("\nDo you want to continue press 'Y' or 'N': ");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y' || ch == 'Y');
            Console.ReadKey();
        }
    }
}
