using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_foreach_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[] arry = { 1, 2, 3, 4, 5 };

            foreach(int i in arry) // syntax: foreach (datatype variable_name in array_name)
            {
                Console.WriteLine(i); // use variable_name instead of array_name
                sum = sum + i;
            }
            Console.WriteLine("\nSum of the array is: " + sum);
            Console.ReadKey(); 
        }
    }
}
