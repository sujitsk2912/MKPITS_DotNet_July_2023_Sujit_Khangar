using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 3, 4, 5 };

            Array.Clear(arry,0,5); // (0,5) 0 means the array starts clearing from 0 to 5 means....

            for( int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.ReadKey();
        }
    }
}
