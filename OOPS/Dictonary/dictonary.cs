using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictonary
{
    internal class Program
    {
        static Dictionary<string,string> li = new Dictionary<string,string>();
        static void Main(string[] args)
        {
            li.Add("US", "United States");
            li.Add("KR", "Koria");
            li.Add("JP", "Japan");
            li.Add("IND", "India");
            li.Add("UK", "United Kingdom");
            li.Add("BZ", "Brazil");

            List<string> key = new List<string>(li.Keys);

            // ---------------- keys ----------------

            Console.WriteLine("Finding keys..."); 
            
            foreach (string s in key)
            {
                Console.WriteLine("Keys: " + s);
            }
            Console.WriteLine();

            List<string> val = new List<string>(li.Values);

            // ---------------- values ----------------

            Console.WriteLine("Finding values...");

            foreach (string s in val)
            {
                Console.WriteLine("values: " + s);
            }
            Console.WriteLine();

            // ---------------- keys and values ----------------

            Console.WriteLine("Finding keys and values...");

            foreach (KeyValuePair<string,string> k in li)
            {
                Console.WriteLine("Keys: {0}, Values: {1} ",k.Key, k.Value);
            }

            // ---------------- count values ----------------

            Console.WriteLine();
            Console.WriteLine("Dictonary has {0} value: ", li.Count);

            Console.ReadKey();

        }
    }
}
