using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=0, j=0;i<=5;i++,j++)
            {
                Console.WriteLine("i= " + i);
                Console.WriteLine("j= " + j);
            }
            Console.ReadKey();
        }
    }
}
