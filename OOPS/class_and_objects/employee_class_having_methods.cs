using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details
{
    internal class Program
    {
        class Employee
        {
            int employee_no;
            string employee_name;
            string designation;
            int salary;

            public void getdata(int emp_no, string emp_name, string des, int sal)
            {
                employee_no = emp_no;
                employee_name = emp_name;  
                designation = des;
                salary = sal;
            }

            public void display()
            {
                Console.WriteLine("Employee Number: " + employee_no);
                Console.WriteLine("Employee Name: " + employee_name);
                Console.WriteLine("Designation: " + designation);
                Console.WriteLine("Salary: " + salary);
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.getdata(123, "sujit", "Manager" , 50000);
            employee.display();
            Console.ReadKey();
        }
    }
}
