using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal
{
    class Student
    {
        protected internal int ID = 123;
        protected internal string Name = "mahesh";

        protected void display()
        {
            Console.WriteLine("ID: " +  ID);
            Console.WriteLine("Name: " +  Name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ID = 12;
            s.Name = "sujit";

            Console.WriteLine("ID: " + s.ID);
            Console.WriteLine("Name: " + s.Name);

            Console.ReadKey();
        }
    }
}
