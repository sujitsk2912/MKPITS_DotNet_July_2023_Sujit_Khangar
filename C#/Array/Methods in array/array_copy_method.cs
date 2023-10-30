using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry1 = { 1, 2, 3, 4, 5 };
            int[] arry2 = new int[5];

            Array.Copy(arry1 , arry2, arry2.Length); // Array.Copy method is used to copy element of Array into another Array

            for(int i = 0; i < arry2.Length; i++)
            {
                Console.WriteLine(arry2[i]);
            }
            Console.ReadKey();
        }
    }
}
