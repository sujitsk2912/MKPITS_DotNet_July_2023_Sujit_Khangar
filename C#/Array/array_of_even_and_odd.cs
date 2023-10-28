using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_even_and_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int i=0, j=0, k=0;

            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :", n);

            int[] num = new int[n];
            int[] arry1 = new int[n];
            int[] arry2 = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("\nElements [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (num[i] % 2 == 0)
                {
                    arry1[j] = num[i];
                    j++;
                }
                else
                {
                    arry2[k] = num[i];
                    k++;
                }
            }

            Console.WriteLine("\nEven Numbers : \n");

            for ( i = 0; i < j; i++)
            {
                Console.WriteLine(arry1[i]);
            }

            Console.WriteLine("\nOdd Numbers : \n");

            for (i = 0; i < k; i++)
            {
                Console.WriteLine(arry2[i]);
            }

            Console.ReadKey();
        }
    }
}
