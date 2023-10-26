using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_shared_variable
{
    internal class Program
    {
       static int num = 20;
        static void Display()
        {
            int num = 10; // local variable 
            Console.WriteLine("num inside method : " + num);
        }
        static void Main(string[] args)
        {
            Display();
            Console.WriteLine("num (shared) : " + num);
            Console.ReadKey();
        }
    }
}
