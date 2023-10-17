using System;
namespace DESIGNATION
{
    class program
    {
        public static void Main(string[] args)
        {
            int bonus=0;
            string designation;

            Console.Write("Enter Designation (manager, clerk, peon): ");
            designation = Console.ReadLine();

            switch(designation)
            {
                case "manager":
                    bonus = 5000;
                    break;

                case "clerk":
                    bonus = 2000;
                    break;

                case "peon":
                    bonus = 1000;
                    break;

                default:
                    Console.WriteLine("Invalid Designation");
                    break;
            }
            Console.WriteLine("\nBonus: {0}", bonus);
            Console.ReadKey();
        }
    }
}