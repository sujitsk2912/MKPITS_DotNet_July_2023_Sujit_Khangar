using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_to_calculate_average_of_marks
{
    internal class Program
    {
        class Student
        {
            string name;
            int rollno, total;
            float average;

            public void getdata(string name, int rollno, int total, float average)
            {
                this.name = name;
                this.rollno = rollno;
                this.total = total;
                this.average = average;
            }

            public void display()
            {
                Console.WriteLine("\n-------- Student details---------\n");
                Console.WriteLine("Student Name: " + name);
                Console.WriteLine("Student Roll No.: " + rollno);
                Console.WriteLine("Total Marks: " + total);
                Console.WriteLine("Average: " + average);
            }
        }
        static void Main(string[] args)
        {
            Student stud = new Student();

            Console.Write("Enter Name: ");
            string sname = Console.ReadLine();

            Console.Write("\nEnter Roll No.: ");
            int roll = Convert.ToInt32(Console.ReadLine());

            int tot = 0, i = 0;
            
            int[] subject = new int[5];

            Console.WriteLine("\nEnter 5 Subject marks: \n");

            for( i = 0; i < 5; i++)
            {
                subject[i] = Convert.ToInt32(Console.ReadLine());
            }

            for( i = 0;i < 5; i++)
            {
                 tot += subject[i];
            }

            float avg = (tot / 5);

            stud.getdata(sname, roll, tot, avg);
            stud.display();
            Console.ReadKey();
        }
    }
}
