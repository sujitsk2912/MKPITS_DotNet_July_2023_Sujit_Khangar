using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @internal
{
    class Student
    {
        internal int ID;
        internal string Name;

        internal void display()
        {
            ID = 123;
            Name = "Sujit";

            Console.WriteLine("ID: " +  ID);
            Console.WriteLine("Name: " +  Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.display();

            Console.ReadKey();
        }
    }
}
