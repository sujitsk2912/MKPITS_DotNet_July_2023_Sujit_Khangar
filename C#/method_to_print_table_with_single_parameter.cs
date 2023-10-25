using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_with_single_parameter
{
    internal class Program
    {
        static int table(int n)
        {
            int counter = 1, res=0;

            for (counter = 1;  counter <= 10; counter++)
                {
                    res = counter * n;
                    Console.WriteLine(n + " * " + counter + " = " + res);
                }
            return res;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int result = table(num);

            Console.ReadKey();

        }
    }
}
