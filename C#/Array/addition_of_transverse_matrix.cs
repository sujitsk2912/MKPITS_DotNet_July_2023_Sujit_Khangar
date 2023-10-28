using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transvers_of_2_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arry1 = { { 1, 2 } };
            int[,] arry2 = { { 11, 22 } };
            int[,] arry3 = new int[2, 2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arry3[row, col] = arry1[col, row] + arry2[row, col];
                }
            }

            // displying addition transverse of 2 matrix

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
