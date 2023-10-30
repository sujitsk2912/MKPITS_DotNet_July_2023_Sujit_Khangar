using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_getlength_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           
            int length = arry.GetLength(0); // GetLength method is used to calculate length of an Array......

            Console.WriteLine("Length of Array is: {0}", length);
           Console.ReadKey();
        }
    }
}
