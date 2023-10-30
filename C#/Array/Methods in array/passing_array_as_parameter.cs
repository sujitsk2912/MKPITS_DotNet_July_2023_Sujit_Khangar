using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_array_as_parameter
{
    internal class Program
    {
        static void Passingarray(int[] array) // store the passed values in array....
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                sum = sum + array[i];
            }
            Console.WriteLine("\nSum of Array is: " + sum + "\n");
        }
        static void Main(string[] args)
        {
            int[] num1 = {1, 2, 3, 4};
            Passingarray(num1); // passing the values from parameter num1

            int[] num2 = {5, 6, 7, 8};
            Passingarray(num2); // passing the values from parameter num2

            Console.ReadKey();
        }
    }
}
