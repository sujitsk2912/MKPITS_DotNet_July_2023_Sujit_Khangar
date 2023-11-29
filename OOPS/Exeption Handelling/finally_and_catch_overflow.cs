using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finally_and_catch_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());


            try
            {
                if (age < 18)
                {
                    Console.WriteLine("Please enter Age Greater than equal to 18");
                    throw new Exception();
                }
            }

            catch (OverflowException ee)
            {
                Console.WriteLine("Enter Age greater than equal to 18");
                age = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ee)
            {
                Console.WriteLine("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine("your Age is: " + age);
            }
                Console.ReadKey();
        }
    }
}


