using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_NullReferenceException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            try
            {
                Console.WriteLine(str);
                throw new Exception("Value is null");
            }

            catch(NullReferenceException ee)
            {
                Console.WriteLine(ee.ToString());
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
