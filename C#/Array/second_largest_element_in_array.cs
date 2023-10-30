using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int i = 0;

            Console.Write("Input the of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array: \n", n);

            int[] arry = new int[n];

            for ( i = 0; i < arry.Length; i++)
            {
                Console.Write("\nElement [{0}]: ", i);
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arry);

            int ln = arry[arry.Length - 2];

            Console.WriteLine("\nThe Second largest element in the array is: {0}", ln);
            Console.ReadKey();
            
        }
    }
}
