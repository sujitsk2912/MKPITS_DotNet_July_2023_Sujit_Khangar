 using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int marks;
            float total = 0, per = 0;
            string grade = null;

            Console.WriteLine("Enter 5 subject marks: \n");
   
            for(int counter=1;  counter <= 5; counter++)
            {
                marks = Convert.ToInt32(Console.ReadLine());
                total = total + marks;
            }
            Console.WriteLine("\nTotal: {0}", total);
            per = (total / 500.0f) * 100.0f;
            Console.WriteLine("\nPercentage: {0}", per);

            if(per >= 90)
            {
                grade = "A";
            }
            else if (per < 90 && per >= 75)
            {
                grade = "B";
            }
            else if (per < 75 && per >= 60)
            {
                grade = "C";
            }
            else if (per < 60 && per >= 45)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("\nGrade: {0}",grade);
            Console.ReadKey();
        }
    }
}