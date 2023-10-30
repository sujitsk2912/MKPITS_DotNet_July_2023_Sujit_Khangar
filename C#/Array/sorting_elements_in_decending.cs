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

            Console.Write("Enter Value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arry = new int[n];

            for (i = 0; i < arry.Length; i++)
            {
                Console.Write("\nElement [{0}]: ", i);
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arry);
            Array.Reverse(arry);

            Console.WriteLine("\nElements of array in sorted deccending order:\n");

            for (i = 0 ; i < arry.Length ; i++)
            {
                Console.WriteLine(arry[i]);
            }

            Console.ReadKey();
        }
    }
}

