using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_of_2_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arry1 = { { 1, 2 } , { 3, 4 } };
            int[,] arry2 = { { 5, 6 } , { 7, 8 } };
            int[,] arry3 = new int[2,2];

            for(int row = 0; row < 2; row++)
            {
                for(int col = 0; col < 2; col++)
                {
                    arry3[row,col] = arry1[row,col] * arry2[row,col];
                }
            }

            // Displaying multiplication of 2 matrix

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arry3[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
