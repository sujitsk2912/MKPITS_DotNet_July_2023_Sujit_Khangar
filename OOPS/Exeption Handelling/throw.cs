using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int res = 0;

            Console.WriteLine("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(age < 18)
                {
                    Console.WriteLine("Your are Not Eeligible for Vote");
                    throw new Exception();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("\nEnter Age greater than equal 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("you are Eligible to vote");

            Console.ReadKey();
        }
    }
}
