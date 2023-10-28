using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n;

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} number of elements in the array :\n", n);

            int[] num = new int[n];

            for(i = 0; i < n; i++)
            {
                Console.Write("\nElement [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe values store into the array are:\n");

            for( i = 0; i < n; i++) 
            {
                Console.Write(num[i] + " ");
            }

            Console.WriteLine("\n\nThe values store into the array in reverse are :\n");

            for(i = n-1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
