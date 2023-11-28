using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class Program
    {
       static LinkedList<string> li = new LinkedList<string>();
        static void Main(string[] args)
        {
            // linklist 

            li.AddLast("a");
            li.AddLast("b");
            li.AddLast("c");
            li.AddLast("d");
            li.AddFirst("e");
            li.AddFirst("f");
            li.AddFirst("g");

            Console.WriteLine("Linked list");
            display();
            Console.WriteLine();

            Console.WriteLine("finding node: b and add before : h");

            LinkedListNode<string> node = li.Find("b"); 
            li.AddBefore(node, "h");

            Console.WriteLine("finding node: b and add after : j");// find and add before node list
            li.AddAfter(node, "j");   // find and add after node list

            display();

            Console.ReadKey();

        }
        public static void display()
        {
            foreach(string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }
}
