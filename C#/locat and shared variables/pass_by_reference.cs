using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_shared_variable
{
    internal class Program
    {
        static void Display(ref int num)
        {
            num = 10;
            Console.WriteLine("num inside method : " + num); // 10
        }
        static void Main(string[] args)
        {
            int num = 20;
            Display(ref num);
            Console.WriteLine("num after passing reference inside main : " + num); // 10
            Console.ReadKey();
        }
    }
}
