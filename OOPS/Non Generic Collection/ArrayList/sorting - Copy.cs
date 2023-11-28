using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();

            ar.Add("sujit");
            ar.Add("trishala");
            ar.Add("prachi");
            ar.Add("chetan");
            ar.Add("lucky");
            Console.WriteLine("Sorting of ArrayList are:");
            ar.Sort();

            foreach (object obj in ar)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
