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
            int cnt = 0;
            int flag = 1;

            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :", n);

            int[] num = new int[n];
            int[] arry = new int[n];
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nElements [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                arry[i] = num[i];
                temp[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if (num[i] == arry[j])
                    {
                        temp[i] = flag;
                        flag++;
                    }
                }
                flag = 1;
            }

            for( int i = 0; i < n;i++)
            {
                if (temp[i] == 2)
                {
                    cnt++;
                }
            }
            Console.WriteLine("\nTotal number of duplicate elements found in the array is : {0} ", cnt);
            Console.ReadKey();
        }
    }
}