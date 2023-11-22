using sealed_class_example_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_example_2
{
    abstract class Person
    {
        public string name;
    }
    class student : Person
    {
        public int rollno;
    }
    sealed class parttimestudeent : student // error occures
    {
        public int salry;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestudeent P = new parttimestudeent();
            P.name = "Sujit";
            P.rollno = 1;
            P.salry = 5000;

            Console.WriteLine("Name: " + P.name);
            Console.WriteLine("Roll No: " + P.rollno);
            Console.WriteLine("Salary: " + P.salry);

            Console.ReadKey();
        }
    }
}
