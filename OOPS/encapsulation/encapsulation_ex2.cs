using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_example_2
{
    class student
    {
        public int rollno { get; set; }
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rollno = 1;
            s.name = "Sujit";

            Console.WriteLine("Roll No: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            Console.ReadKey();
        }
    }
}
