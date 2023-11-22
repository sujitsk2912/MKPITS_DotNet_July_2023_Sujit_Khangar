using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_access
{
    class Student
    {

        private string Name = "Sujit";

        private void display(string Name)
        {

            Console.WriteLine("Name: " + Name);
        }

    }

        internal class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.display(); // error due to method is protected 

                Console.ReadKey();
            }
        }
    }


