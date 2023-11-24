using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist_key_using_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("5", "sahil");
            sl.Add("2", "amit");
            sl.Add("1", "pranay");
            sl.Add("4", "lucky");
            sl.Add("7", "sujit");
            sl.Add("6", "sarang");

            ICollection key = sl.Keys;

            foreach(string s  in key)
            {
                Console.WriteLine("No: " + s + " : " + "Name: " + sl[s]);
            }

            Console.ReadKey();
        }
    }
}
