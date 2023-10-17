using System;
namespace VOVEL
{
    class consonant
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter Letter: ");
            ch = Convert.ToChar(Console.ReadLine());

            if ( ch == 'A' || ch == 'E'|| ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The alphabet is Vovel.");
            }

            else
            {
                Console.WriteLine("The alphabet is consonant.");
            }

            Console.ReadKey();  
        }
    }
}