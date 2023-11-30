using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_StackOverflowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;

            Console.WriteLine("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(Age < 18)
                {
                    throw new Exception("Enter age greater than or equal to 18");
                }
            }
            catch (OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter a small number");
                Age = Convert.ToInt32(Console.ReadLine());

            }

            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age greater than 18");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("You are {0} years old", Age);
            }

            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
