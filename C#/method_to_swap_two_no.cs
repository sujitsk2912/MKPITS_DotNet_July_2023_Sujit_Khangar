using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping_of_two_numbers
{
    internal class Program
    {
        static int Swap(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("\nNow the 1st number is " + x); 
            Console.WriteLine("And");
            Console.WriteLine("The 2nd number is " + y);
            
            return x;
            return y;

        }
        
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = Swap(num1, num2);
            Console.ReadKey();
        }
    }
}
