using System;
namespace VOVEL
{
    class program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter charachter: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("\nit is vovel",ch);
                    break;

                default:
                    Console.WriteLine("it is not vovel");
                    break;
            }
            Console.ReadKey();
        }
    }
}