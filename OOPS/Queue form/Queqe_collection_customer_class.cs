using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queqe_collection_customer_class
{
    class customer
    {
        public int custid;
        public string name;
        public string email;
        public long phone;

        public customer(int custid, string name, string email, long phone) 
        {
            this.custid = custid;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // first-in first out

            customer c1 = new customer(1, "sujit", "skhangar321@gmail.com", 9579120646);
            customer c2 = new customer(2, "sahil", "smirase123@gmail.com", 7428103277);
            customer c3 = new customer(3, "trish", "bhisikartrsihala123@gmail.com", 7499970761);

            Queue q = new Queue();

            q.Enqueue(c1);
            q.Enqueue(c2);
            q.Enqueue(c3);

            Console.WriteLine("----- Customer before Dequequ-------\n");

            foreach(customer c in q) 
            {
                Console.WriteLine("Customer ID  : " + c.custid);
                Console.WriteLine("Customer Name: " + c.name);
                Console.WriteLine("Email        : " + c.email);
                Console.WriteLine("Phone        : " + c.phone);
                Console.WriteLine();
            }

            q.Dequeue();

            Console.WriteLine("----- Customer after Dequequ-------\n");

            foreach (customer c in q)
            {
                Console.WriteLine("Customer ID  : " + c.custid);
                Console.WriteLine("Customer Name: " + c.name);
                Console.WriteLine("Email        : " + c.email);
                Console.WriteLine("Phone        : " + c.phone);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
