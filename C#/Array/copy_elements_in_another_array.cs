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
           
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :", n);

            int[] num = new int[n];
            int[] arry2 = new int[n];
            int[] temp = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("\nElements [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe elements stored in the first array are : \n");

            for (i = 0; i < n; i++)
            {
                Console.Write(num[i] + " ");
                temp[i] = num[i];
            }

            Console.WriteLine("\n\nThe elements copied into the second array are :\n");

            for (i = 0;i < n; i++)
            {
                arry2[i] = temp[i];
                Console.Write(arry2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
