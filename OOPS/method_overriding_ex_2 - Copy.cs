using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding_ex_2
{
    public class MKPITS
    {
        public virtual void get()
        {
            Console.WriteLine("WELCOME TO MKPITS");
        }
    }

    public class mkpits: MKPITS
    {
        public override void get()
        {
            Console.WriteLine("THANK YOU FOR VISITING...");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MKPITS M = new MKPITS();
            M.get();

            mkpits m = new mkpits();
            m.get();

            Console.ReadKey();
        }
    }
}
