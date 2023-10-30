using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_3x3_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            Console.WriteLine("Input elements in the matrix: \n");    

            int[,] arry = new int[3,3];

            for(row = 0; row < 3; row++)
            {
                for(col = 0; col < 3; col++)
                {
                    Console.Write("\nElement [{0}],[{1}]: ", row, col);
                    arry[row,col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix is :\n");

            for(row = 0;row < 3; row++)
            {
                for (col = 0;col < 3; col++)
                {
                    Console.Write(arry[row,col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
