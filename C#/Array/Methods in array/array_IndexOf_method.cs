using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_indexOf_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 6, 7, 5, 4, 3, 9, 8 };

            int index = Array.IndexOf(arry, 5); // Array.IndexOf method is used to find the index of an element in the array.....

            Console.WriteLine("Index of 5 is: {0} ", index);
            Console.ReadKey();
        }
        
    }
}
