using System;
namespace STUDENT
{
    class Grade
    {
        public static void Main(string[] args)
        {
            int math, phy, che;
            float total, per;
            string grade=null;

            Console.Write("Enter Mathematics Marks: ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Marks: ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks: ");
            che = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------");

            total = math + phy + che;
            Console.WriteLine("Total Marks: " + total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage: " + per);

            if(per >= 90)
            {
                grade = "Distinction";
            }

            else if (per >= 75 && per < 90)
            {
                grade = "First Class";
            }

            else if (per >= 60 && per < 75)
            {
                grade = "Second Class";
            }

            else
            {
                grade = "Fail";
            }

            Console.WriteLine("Grade: {0} ", grade);
            Console.ReadKey();  

        }
    }
}