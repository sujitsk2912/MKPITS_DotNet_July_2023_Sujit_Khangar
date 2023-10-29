using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traspose_of_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row =0;
            int col =0;

            Console.WriteLine("Input the rows and columns of the matrix: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[,] arry = new int[n1,n2];

            Console.WriteLine("\nInput elements in the first matrix : \n");

            for (row = 0; row < n1; row++)
            {
                for (col = 0; col < n2; col++)
                {
                    Console.Write("Elements [{0}],[{1}]: ", row, col);
                    arry[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix is :\n");

            for (row = 0; row < n1; row++)
            {
                for (col = 0; col < n2; col++)
                {
                    Console.Write(arry[row,col] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Transpose of a matrix is :\n");

            for (col = 0; col < n2; col++)
            {
                for (row = 0; row < n1; row++)
                {
                    Console.Write(arry[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
