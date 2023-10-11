using System;
namespace numbertable
{
    class table
    {
        static void Main()
        {
            int num = 10, i = 1, result = 0;

            for (i = 1; i <= num; i++)
            {
                result = num * i;
                Console.WriteLine(num + " * " + i + " = " + result);
            }
            Console.ReadKey();
        }
    }
}