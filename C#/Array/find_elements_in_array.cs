using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int userno;

            Console.Write("Enter number to be searched: ");
            userno = Convert.ToInt32(Console.ReadLine());

            for( int i = 0; i < num.Length; i++ )
            {
                if( num[i] == userno)
                {
                    flag = 1;
                    break;
                }
            }

            if ( flag == 1 )
            {
                Console.WriteLine("num {0} is found in an array", userno);
            }
            else
            {
                Console.WriteLine("num is not found in an array");
            }
            Console.ReadKey();
        }
    }
}
