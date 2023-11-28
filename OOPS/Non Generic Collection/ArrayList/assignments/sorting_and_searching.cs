using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorrting_and_searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            
            myList.Sort();

            foreach(object obj in myList) 
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();

        }
    }
}
