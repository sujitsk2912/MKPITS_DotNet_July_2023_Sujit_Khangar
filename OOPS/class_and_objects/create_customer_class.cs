using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_customer_class_and_its_objects
{
    internal class Program
    {
        class Customer
        {
            // by default the Class is private........

            public int customer_code; 
            public string customer_name;
        }
        static void Main(string[] args)
        {
            // creating object of the class

            //syntax of object is 
            // syntax: Classname objectname = new classname

            Customer cust = new Customer();

            cust.customer_code = 123;
            cust.customer_name = "Sujit";

            Console.WriteLine("Customer Code: " + cust.customer_code);
            Console.WriteLine("Customer Name: " + cust.customer_name);
            Console.ReadKey();
        }
    }
}
