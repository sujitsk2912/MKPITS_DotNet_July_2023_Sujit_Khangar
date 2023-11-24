using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_and_adding_key
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "sujit");
            ht.Add("2", "sahil");
            ht.Add("3", "samir");
            ht.Add("4", "suraj");
            ht.Add("5", "sumit");

            ICollection key = ht.Keys;

            if(ht.ContainsValue("suraj")) 
            {
                Console.WriteLine("Name is alrealdy exist in the list");
            }
            else
            {
                ht.Add("6", "suraj");
            }

            foreach(string s  in key)
            {
                Console.WriteLine("No: " + s + " , " + "Name: " + ht[s]);
            }

            Console.ReadKey();
        }
    }
}
