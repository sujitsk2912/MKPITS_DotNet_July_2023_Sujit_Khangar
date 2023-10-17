using System;
namespace DAYNAME
{
    class program
    {
        public static void Main(string[] args)
        {
            int dayno;
            string dayname=null;

            Console.Write("Enter Day No.: ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch(dayno)
            {
                case 1:
                    dayname = "Monday";
                    break;

                case 2:
                    dayname = "Tuesday";
                    break;

                case 3:
                    dayname = "Wednesday";
                    break;

                case 4:
                    dayname = "Thursday";
                    break;

                case 5:
                    dayname = "Friday";
                    break;

                case 6:
                    dayname = "Saturday";
                    break;

                case 7:
                    dayname = "Sunday";
                    break;

                default:
                    Console.WriteLine("\nInvalid Day No.");
                    break;  

            }
            Console.WriteLine("\n{0}", dayname);
            Console.ReadKey();
        }
    }
}