using System;
namespace DISPLAY_WORD
{
    class program
    {
        public static void Main(string[] args)
        {
            int num;
            string word=null;

            Console.Write("Enter Number from (1 - 9) : ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    word = "One";
                    break;

                case 2:
                    word = "Two";
                    break;

                case 3:
                    word = "Three";
                    break;

                case 4:
                    word = "Four";
                    break;

                case 5:
                    word = "Five";
                    break;
      
                case 6:
                    word = "Six";
                    break;

                case 7:
                    word = "Seven";
                    break;

                case 8:
                    word = "Eight";
                    break;

                case 9:
                    word = "Nine";
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
            Console.WriteLine("\n{0}",word);
            Console.ReadKey();
        }
    }
}