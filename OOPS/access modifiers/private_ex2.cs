using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_access
{

    internal class Program
    {
        class Student
        {
            private string Name = "Sujit";

            private void display()
            {
                Console.WriteLine("Name: " + Name);
            }


            static void Main(string[] args)
            {
                Student s = new Student();
                Console.WriteLine("Name: " +  s.Name);

                Console.ReadKey();
            }
        }
    }
}


