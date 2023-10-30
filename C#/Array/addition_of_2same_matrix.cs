using System;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            Console.WriteLine("Input the number of rows and columns for the first matrix: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the number of rows and columns for the second matrix: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());

            if (n2 != n3)
            {
                Console.WriteLine("\nMatrix Addition is not possible");
                Console.ReadKey();
                return;
            }
            else
            {
                int[,] array1 = new int[n1, n2];
                int[,] array2 = new int[n3, n4];
                int[,] array3 = new int[n1, n4];

                Console.WriteLine("\nInput elements for the first matrix:\n");

                for (row = 0; row < n1; row++)
                {
                    for (col = 0; col < n4; col++)
                    {
                        Console.Write("Element [{0}],[{1}] : ", row, col);
                        array1[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nInput elements for the second matrix:\n");

                for (row = 0; row < n1; row++)
                {
                    for (col = 0; col < n2; col++)
                    {
                        Console.Write("Element [{0}],[{1}] : ", row, col);
                        array2[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nThe First matrix is:\n");

                for (row = 0; row < n1; row++)
                {
                    for (col = 0; col < n2; col++)
                    {
                        Console.Write(array1[row, col] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nThe Second matrix is:\n");

                for (row = 0; row < n3; row++)
                {
                    for (col = 0; col < n4; col++)
                    {
                        Console.Write(array2[row, col] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nThe result of matrix Addition is:\n");

                for (row = 0; row < n1; row++)
                {
                    for (col = 0; col < n2; col++)
                    {
                        array3[row, col] = array1[row, col] + array2[row, col];
                    }
                }

                for (row = 0; row < n3; row++)
                {
                    for (col = 0; col < n4; col++)
                    {
                        Console.Write(array3[row, col] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
