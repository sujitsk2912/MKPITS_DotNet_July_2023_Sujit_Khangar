using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 3 };

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Array: " + arry[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("Finally code executed");
            }

            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
