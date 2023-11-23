using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("trish");
            ar.Add("sujit");
            ar.Add("sanjay");

            foreach(object obj in ar)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
