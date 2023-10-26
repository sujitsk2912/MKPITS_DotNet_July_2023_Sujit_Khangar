using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_value_from_user_to_store_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] num = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Numbers: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                 sum = sum + num[i];               
            }
            Console.WriteLine("sum of array elements is: {0}", sum);
            Console.ReadKey();
        }
    }
}
