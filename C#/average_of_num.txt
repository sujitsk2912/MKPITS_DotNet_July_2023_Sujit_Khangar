using System;
namespace averageofnum
{
    class average
    {
        static void Main()
        {
            int num1, num2, num3, num4, avg, sum;
            Console.Write("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num3:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num4:");
            num4 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3 + num4;
            avg = sum / 4;
            Console.WriteLine("-------------");
            Console.WriteLine("Average of: " + num1 + "," + num2 +"," + num3 +"," + num4 + " is " + avg);
        }
    }
}