using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @protected
{
     class emplyee
    {
        protected int ID;
        protected string Name;

        protected void display()
        {
            ID = 123;
            Name = "Sujit";

            Console.WriteLine("Employee ID: " + ID);
            Console.WriteLine("Employee Name: " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emplyee emp = new emplyee();
            emp.display(); // error due to display method is protected

            Console.ReadKey();
        }
    }
}


