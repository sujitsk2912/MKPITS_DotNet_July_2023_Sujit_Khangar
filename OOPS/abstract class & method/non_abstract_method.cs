using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_abstract_method
{
    abstract class Account
    {
        public abstract void deposite(); // abstract method

        public void showbalannce() // not abstract method
        {
            Console.WriteLine("non abstract showbalance method");
        }
    }

    class saving: Account 
    {
        public override void deposite() 
        {
            Console.WriteLine("Hellow from saving deposite account");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new saving();
            act.deposite();
            act.showbalannce();
            Console.ReadKey ();
        }
    }
}
