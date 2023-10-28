using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace unique_elements_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int i, j, k;

            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :", n);

            int[] num = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("\nElements [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe unique elements found in the array are : ");

            for (i = 0; i < n; i++)
            {
                cnt = 0;
                for (j = 0; j < i - 1; j++)
                {
                    if (num[i] == num[j])
                    {
                        cnt++;
                    }
                }

                for (k = i + 1; k < n; k++)
                {
                    if (num[i] == num[k])
                    {
                        cnt++;
                    }

                    if (num[i] == num[i + 1])
                    {
                        i++;
                    }
                }

                if (cnt == 0)
                {
                    Console.Write("{0} ", num[i]);
                }
            }
            Console.ReadKey();
        }
    }
}