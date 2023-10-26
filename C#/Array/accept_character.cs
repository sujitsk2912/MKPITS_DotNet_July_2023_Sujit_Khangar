using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_3_charachter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[3];
            
            for(int i = 0; i < ch.Length; i++) 
            {
                Console.Write("Enter character: ");
                ch[i] = Convert.ToChar(Console.ReadLine());

            }
            Console.Write("\ncharacter: ");
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write("{0}", ch[i]);
            }

            Console.ReadKey();
        }
    }
}
