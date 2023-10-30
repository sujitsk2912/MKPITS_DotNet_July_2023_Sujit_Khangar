using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_returning_method
{
    internal class Program
    {
        static int[] returning()
        {
            int[] num = {1, 2, 3, 4};
            return num;
        }

        static void Main(string[] args)
        {
            int[] res = returning();

            for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
             Console.ReadKey();
        }
    }
}
