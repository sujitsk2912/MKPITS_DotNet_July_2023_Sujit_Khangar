using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stuudent_class_of_arrylist_using_console
{
    class student
    {
        public int Rollno;
        public string Name;

        public student(int Rollno, string Name) 
        {
            this.Rollno = Rollno;
            this.Name = Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(1, "sujit");
            student s2 = new student(2, "samir");
            student s3 = new student(3, "sahil");

            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);

            foreach(student s in ar)
            {
                Console.WriteLine("Roll No: " + s.Rollno);
                Console.WriteLine("Name: " + s.Name);
                
            }

            Console.ReadKey();
        }
    }
}
