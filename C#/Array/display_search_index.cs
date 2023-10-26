using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_search_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int[] num = { 12, 23, 3, 44, 54 };

            Console.Write("Enter Number to be searched: ");
           int search = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 5; i++)
            {
                if( num[i] == search )
                {
                    flag = 1;
                    Console.WriteLine("\nnum {0} is found on search index of {1}", search, i+1);
                    break;
                }
            }

            if( flag == 1 )
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("num is not found in an array");
            }

            Console.ReadKey();
        }
    }
}
