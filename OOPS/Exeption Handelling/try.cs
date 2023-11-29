using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int n = 0;
            int res = num / n; // error will occure and program terminated
            Console.WriteLine("Result: " + res);

            Console.ReadKey();
        }
    }
}
