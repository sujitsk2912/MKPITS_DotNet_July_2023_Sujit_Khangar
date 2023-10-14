using System;
namespace EQUIVALENT
{
    class Equivalent
    {
        public static void Main(string[] args)
        {
            char grade;
            string description=null;

            Console.Write("Enter Grade (E, V, G, A, F): ");
            grade = Convert.ToChar(Console.ReadLine());

            if( grade == 'E')
            {
                description = "Excellent";
            }

            else if(grade == 'V')
            {
                description = "Very Good";
            }

            else if (grade == 'G')
            {
                description = "Good";
            }

            else if (grade == 'A')
            {
                description = "Average";
            }

            else if (grade == 'F')
            {
                description = "Fail";
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }

            Console.WriteLine("\nYou have chosen : " + description);
            Console.ReadKey();
        }
    }
}