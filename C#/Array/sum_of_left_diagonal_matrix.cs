using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_right_diagonal_of_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            Console.WriteLine("Input the size of the square matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = n;

            Console.WriteLine("\nInput elements in the first matrix: \n");

            int[] num = new int[n];
            int sum = 0;
            int[,] arry = new int[n, n];

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("Elements [{0}],[{1}]: ", row, col);
                    arry[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe First matrix is :\n");

            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write(arry[row, col] + "\t");
                }

                Console.WriteLine();
            }

            for (row = 0; row < n; row++)
            {
                m = m - 1;
                for (col = 0; col < n; col++)
                {
                    if (col == m)
                    {
                        sum += arry[row, col];
                    }
                }
            }

            Console.WriteLine("\nsum of left diagonal matrix are: {0}", sum);
            Console.ReadKey();
        }
    }
}
