using System;

namespace READNO
{
    class Read
    {
        public static void Main(string[] args)
        {
            int digit;
            string month = null;

            Console.Write("Enter Month in Digit : ");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
            {
                month = "January";
            }
            else if (digit == 2)
            {
                month = "February";
            }
            else if (digit == 3)
            {
                month = "March";
            }
            else if (digit == 4)
            {
                month = "April";
            }
            else if (digit == 5)
            {
                month = "May";
            }
            else if (digit == 6)
            {
                month = "June";
            }
            else if (digit == 7)
            {
                month = "July";
            }
            else if (digit == 8)
            {
                month = "August";
            }
            else if (digit == 9)
            {
                month = "September";
            }
            else if (digit == 10)
            {
                month = "Octomber";
            }
            else if (digit == 11)
            {
                month = "November";
            }
            else if (digit == 12)
            {
                month = "December";
            }
            else
            {
                Console.WriteLine("Invalid Digit");
            }

            Console.WriteLine("\nMonth : " + month);
            Console.ReadKey();
        }
    }
}
