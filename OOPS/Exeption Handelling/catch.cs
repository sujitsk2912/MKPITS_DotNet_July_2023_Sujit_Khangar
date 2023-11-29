using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cathch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            int res = 0;

            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number which divide by: ");
            n = Convert.ToInt32(Console.ReadLine());

            try
            {
                res = num / n; // error will occure and program terminated
            }

            catch (Exception ee)
            {
                Console.WriteLine("The value is cannot divided by zero");
            }

            Console.WriteLine("Result: " + res);

            Console.ReadKey();
        }
    }
}
