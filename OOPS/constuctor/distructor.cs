using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disctructor
{
    internal class Program
    {
        class Employee
        {
            // calling constructor

            public Employee()
            {
                Console.WriteLine("Constructor called");
            }

            ~ Employee()
            {
                Console.WriteLine("Distructor called");
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();

            Employee emp2 = new Employee();
            Console.ReadKey();
        }
    }
}
