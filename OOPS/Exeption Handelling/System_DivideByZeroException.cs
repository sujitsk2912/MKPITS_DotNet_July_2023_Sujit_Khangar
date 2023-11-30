using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_DivideByZeroException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;

            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value to be divided: ");
            n = Convert.ToInt32(Console.ReadLine());

            try
            {
                int res = num / n;
            }
            catch(DivideByZeroException ee) 
            {
                Console.WriteLine(ee.ToString());
            }

            Console.WriteLine("Bye..");
            Console.ReadKey();
        }
    }
}
