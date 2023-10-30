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
            int i = 0;
            int[] arry = { 1, 7, 9, 8, 5 };

            Array.Reverse(arry); // Array.Reverse used to reverse the array elements ex:(1,2,3,4) to (4,3,2,1)

            for( i = 0;  i < arry.Length; i++)
            { 
                Console.WriteLine(arry[i]);
            }
            Console.ReadKey();
        }
    }
}
