using System;

namespace BaseToThePowerMethod
{
    class Program
    {
        static int CalculatePower(int Base, int expo)
        {
            int res = 1;

            for (int i = 0; i < expo; i++)
            {
                res *= Base;
            }

            return res;
        }

        static void Main(string[] args)
        {
            int baseNumber, exponent;
            Console.WriteLine("Input Base Number: ");
            baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            int result = CalculatePower(baseNumber, exponent);

            Console.WriteLine("So, the number " + baseNumber + "^" + exponent + " = " + result);
            Console.ReadKey();
        }
    }
}
