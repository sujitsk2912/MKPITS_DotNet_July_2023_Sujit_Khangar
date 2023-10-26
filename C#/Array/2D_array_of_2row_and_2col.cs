using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_of_2_row_and_2_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2 } , { 3, 4 } };

            for(int row = 0;  row < 2;  row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(num[row,col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
