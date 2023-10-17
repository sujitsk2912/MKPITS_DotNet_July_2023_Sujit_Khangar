using System;

namespace READNO
{
    class Read
    {
        public static void Main(string[] args)
        {
            int digit;
            string days = null, month = null;

            Console.Write("Enter Month in Digit : ");
            digit = Convert.ToInt32(Console.ReadLine());

           switch (digit)
            {
                case 1:
                month = "January";
                days = "31";
                    break;

                case 2:
                month = "February";
                days = "28";
                    break;

                case 3:
                month = "March";
                days = "31";
                    break;

                case 4:
                month = "April";
                days = "30";
                    break;

                case 5:
                month = "May";
                days = "31";
                    break;

                case 6:
                month = "June";
                days = "30";
                    break;

                case 7:
                month = "July";
                days = "31";
                    break;

                case 8:
                month = "August";
                days = "31";
                    break;

                case 9:
                month = "September";
                days = "30";
                    break;

                case 10:
                month = "Octomber";
                days = "31";
                    break;

                case 11:
                month = "November";
                days = "30";
                    break;

                case 12:
                month = "December";
                days = "31";
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
               
            Console.WriteLine("\n{0} have {1} Days",month,days);
            Console.ReadKey();
        }
    }
}
