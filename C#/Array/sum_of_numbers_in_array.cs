using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_numbers_in__array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;

            Console.Write("Input the number of elements to be stored in the array : ");
           int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :",n);

            int[] num = new int[n];

            for ( i = 0; i < n; i++ )
            {
                Console.Write("\nElements [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());      
            }

            for( i = 0; i < n; i++ )
            {
                sum = sum + num[i];
            }
            Console.WriteLine("\nSum of all elements stored in the array is : {0}", sum);
            Console.ReadKey();
        }
    }
}
