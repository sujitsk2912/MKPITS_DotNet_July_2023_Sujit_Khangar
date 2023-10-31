using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_class
{
    internal class Program
    {
        class Person
        {
            string name;
            string address;
            int age;

            public void getdata(string name, int age, string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }

            public void display()
            {
                Console.WriteLine("\n--------- Person Details ----------\n");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Address: " +  address);
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine("Enter Name: ");
            string p_name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int p_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Address: ");
            string p_add = Console.ReadLine();

            p.getdata(p_name, p_age, p_add);
            p.display();

            Console.ReadKey();
        }
    }
}
