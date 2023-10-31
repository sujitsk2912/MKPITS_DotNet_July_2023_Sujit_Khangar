using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_customer_class_having_methods
{
    internal class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;

            public void getdata(int cc, string cn)
            {
                customer_code = cc;
                customer_name = cn;
            }
            
            public void Display()
            {
                Console.WriteLine("Customer Code: " +  customer_code);
                Console.WriteLine("Customer Name: " + customer_name);
            }
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata( 123, " Sujit");
            cust.Display();
            Console.ReadKey();
        }
    }
}
