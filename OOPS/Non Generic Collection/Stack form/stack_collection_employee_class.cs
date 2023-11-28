using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_collection_employee_class
{
    class Employee
    {
        public int empno;
        public string empname;
        public int salary;
        public string designation;

        public Employee(int empno, string empname, int salary, string designation) 
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.designation = designation;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // last-in first out 
                
            Employee e1 = new Employee(1, "sujit", 12000, "peon");
            Employee e2 = new Employee(2, "samir", 12000, "peon");
            Employee e3 = new Employee(3, "sahil", 12000, "peon");

            Stack emp = new Stack();

            emp.Push(e1);
            emp.Push(e2);
            emp.Push(e3);

            Console.WriteLine("-------- Before popping ------\n");

            foreach (Employee e in emp)
            {
                Console.WriteLine("Employee No: " + e.empno);
                Console.WriteLine("Name: " + e.empname);
                Console.WriteLine("Salary: " + e.salary);
                Console.WriteLine("Designatiom: " + e.designation);
                Console.WriteLine();
            }

            emp.Pop();

            Console.WriteLine("-------- After popping ------\n");

            foreach (Employee e in emp)
            {
                Console.WriteLine("Employee No: " + e.empno);
                Console.WriteLine("Name: " + e.empname);
                Console.WriteLine("Salary: " + e.salary);
                Console.WriteLine("Designatiom: " + e.designation);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
