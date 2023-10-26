using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_length_parameter
{
    internal class Program
    {
        static int calculate(params int[] num)
        {
            int i, total = 0;

            for(i = 0; i < num.Length; i++)
            {
                total = total + num[i]; // 0+1=1, 1+2=3, 3+3=6
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result = calculate(1, 2, 3);
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
