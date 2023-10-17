using System;
namespace DSIPLAY_MONTH
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            string month=null;

            Console.Write("Enter Month No.: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    month = "January";
                    break;

                case 2:
                    month = "February";
                    break;

                case 3:
                    month = "March";
                    break;

                case 4:
                    month = "April";
                    break;

                case 5:
                    month = "May";
                    break;

                case 6:
                    month = "June";
                    break;

                case 7:
                    month = "July";
                    break;

                case 8:
                    month = "Auguest";
                    break;

                case 9:
                    month = "September";
                    break;

                case 10:
                    month = "Octomber";
                    break;

                case 11:
                    month = "Novmber";
                    break;

                case 12:
                    month = "December";
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
            Console.WriteLine("\nMonth: {0}", month);
            Console.ReadKey();
        }
    }
}