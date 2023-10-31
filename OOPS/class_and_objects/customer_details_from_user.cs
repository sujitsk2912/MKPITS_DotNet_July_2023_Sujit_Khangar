using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_details_from_user
{
    internal class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;

            public void getdata(int customer_code, string customer_name)
            {
                this.customer_code = customer_code;
                this.customer_name = customer_name;
            }

            public void display()
            {
                Console.WriteLine("Customer Code: " + customer_code);
                Console.WriteLine("Customer Name: " + customer_name);
            }
        }

        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter Customer Code: ");
            int cust_code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            string cust_name = Console.ReadLine();

            customer.getdata( cust_code, cust_name);
            customer.display();
            Console.ReadKey();
        }
    }
}
