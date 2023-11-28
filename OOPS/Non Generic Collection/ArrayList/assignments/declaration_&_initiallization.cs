using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace declaration___initiallization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            foreach(object obj in myList)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
