using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emcapsulation_ex1
{
    class employee
    {
        public string name { get; set; }  // encapsulate using get and set method
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.name = "sujit";
            Console.WriteLine("Employee Name: " + emp.name);

            Console.ReadKey();
        }
    }
}
