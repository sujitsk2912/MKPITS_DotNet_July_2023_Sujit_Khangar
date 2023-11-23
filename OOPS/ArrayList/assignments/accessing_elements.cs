using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessing_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            foreach(object obj in myList)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
