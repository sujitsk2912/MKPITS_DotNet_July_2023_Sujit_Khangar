using System;
namespace STUDENT
{
    class Grade
    {
        public static void Main(string[] args)
        {
            int rollno, math, phy, che;
            float total, per;
            string division = null, name;

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Roll No.: ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mathematics Marks: ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Marks: ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks: ");
            che = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------");


            total = math + phy + che;
            per = (total / 300.0f) * 100.0f;

            if (per >= 90)
            {
                division = "First";
            }

            else if (per >= 75 && per < 90)
            {
                division = "Second";
            }

            else if (per >= 60 && per < 75)
            {
                division = "Third";
            }

            else
            {
                division = "Fail";
            }

            Console.WriteLine(" Name: {0} \n Roll No.: {1} \n Total marks: {2} \n Percentage: {3} \n Division: {4} ",name, rollno, total, per, division);
            Console.ReadKey();

        }
    }
}