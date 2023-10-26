using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_5_sub_marks_and_print_total__per__and_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float total = 0, per=0;
            string grade = null; 

            int[] marks = new int[5];

            Console.WriteLine("Enter 5 Subject Marks: ");

            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0;i < 5;i++)
            {
                total = total + marks[i];
                per = (total / 500.0f) * 100.0f;
            }
            Console.WriteLine("\nTotal of 5 subjects are: {0}", total);
            Console.WriteLine("\nPercentage: {0}", per);

            if(per >= 90)
            {
                grade = "Distinction";
            }
            else if (per >= 75 && per < 90 )
            {
                grade = "First";
            }
            else if (per >= 65 && per < 75)
            {
                grade = "Second";
            }
            else if (per >= 45 && per < 65)
            {
                grade = "Third";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("\nGrade: {0}", grade);
            Console.ReadKey();
        }
    }
}
