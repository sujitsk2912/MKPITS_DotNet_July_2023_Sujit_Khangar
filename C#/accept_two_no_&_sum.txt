using System;

namespace sumoftwonum
{
    class sum
    {
        static void Main()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2=Convert.ToInt32(Console.ReadLine());
            sum = num1+ num2;
            Console.WriteLine("sum: " + sum);
            Console.ReadKey();
        }
    }
}