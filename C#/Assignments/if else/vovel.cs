using System;
namespace VOVEL
{
    class program
    {
        public static void Main(string[] args)
        {
            string ch;
            int num;

            Console.Write("Enter Characher: ");
            ch = Console.ReadLine();
            num = Convert.ToInt32(ch);
        
            if((ch == "a") || (ch == "e") || (ch == "i") || (ch == "o") || (ch == "u"))
            {
                Console.WriteLine("It is lowercase Vovel");
            }
            else if((ch == "A") || (ch == "E") || (ch == "I") || (ch == "O") || (ch == "U"))
            {
                Console.WriteLine("It is Uppercase Vovel");
            }
            else if( num < 0 && num >= 0 )
            {
                Console.WriteLine("It is Digit");
            }
            else            {
                Console.WriteLine("It is any Other symbol");
            }

            Console.ReadKey();
        }
    }
}