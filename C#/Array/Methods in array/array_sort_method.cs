using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 7, 9, 8, 5 };

            Array.Sort(arry); // Array.Reverse used to sort the array elements ex: (1,5,2,3,6) to (1,2,3,5,6)

            for(int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.ReadKey();
        }
    }
}
