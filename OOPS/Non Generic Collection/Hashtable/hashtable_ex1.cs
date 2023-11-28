using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "sujit");
            ht.Add("2", "sahil");
            ht.Add("3", "samir");
            ht.Add("4", "sumit");
            ht.Add("5", "suraj");

            ICollection key = ht.Keys;

            foreach(string s  in key)
            {
                Console.WriteLine("No: " + s + " , " + "Name: " + ht[s]);
            }

            Console.ReadKey();
        }
    }
}
