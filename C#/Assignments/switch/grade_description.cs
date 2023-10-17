using System;
using System.Diagnostics;

namespace EQUIVALENT_GRADE
{
    class program
    {
        public static void Main(string[] args)
        {
            char grade;
            string description = null;

            Console.Write("Enter Grade (E, V, G, A, F): ");
            grade = Convert.ToChar(Console.ReadLine());

            switch(grade)
            {
                case 'E':
                    description = "Excellent";
                    Console.WriteLine("\nDescription: {0}", description);
                    break;

                case 'V':
                    description = "Very Good";
                    Console.WriteLine("\nDescription: {0}", description);
                    break;

                case 'G':
                    description = "Good";
                    Console.WriteLine("\nDescription: {0}", description);
                    break;

                case 'A':
                    description = "Average";
                    Console.WriteLine("\nDescription: {0}", description);
                    break;

                case 'F':
                    description = "Fail";
                    Console.WriteLine("\nDescription: {0}", description);
                    break;

                default:
                    Console.WriteLine("\nInvalid Grade");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}