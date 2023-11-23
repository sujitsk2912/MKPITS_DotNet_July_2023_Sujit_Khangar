using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capacity_and_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5); 
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            foreach(object obj in myList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("capacity of Array is : " + myList.Capacity);
            Console.WriteLine("Count of elements is : " + myList.Count);
            
            Console.ReadKey();
        }
    }
}
