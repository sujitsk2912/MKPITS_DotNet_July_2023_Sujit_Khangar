using System;
namespace EMPLOYEE
{
    class Employee
    {
        public static void Main()
        {
            int empno, basicsal;
            string empname, designation = null;
            float bonus=0, totalsal=0;

            Console.Write("Enter Employee No.: ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            empname = Convert.ToString(Console.ReadLine());
            Console.Write("Basic Salary: ");
            basicsal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Designation: (manager, clerk, peon): ");
            designation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");

            if (designation == "manager")
            {
                bonus = basicsal * 0.55f;
            }

            else if (designation == "clerk")
            {
                bonus = basicsal * 0.25f;
            }

            else if (designation == "peon")
            {
                bonus = basicsal * 0.10f;
            }

            else
            {
                Console.WriteLine("Invalid Designation");
            }

            totalsal = basicsal + bonus;

            Console.WriteLine("Employee No.: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Basic Salary: " + basicsal);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary: " + totalsal);
            Console.ReadKey();
        }
    }
}