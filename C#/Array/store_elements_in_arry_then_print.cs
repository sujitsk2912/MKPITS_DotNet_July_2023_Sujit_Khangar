using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_array_and_print_them
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            int[] num = new int[10];
 
            for ( i = 0; i < num.Length; i++)
            {
                    Console.Write("Element [{0}]:", i);
                    num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");

            for ( i = 0; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }
           
            Console.ReadKey();
        }
    }
}
