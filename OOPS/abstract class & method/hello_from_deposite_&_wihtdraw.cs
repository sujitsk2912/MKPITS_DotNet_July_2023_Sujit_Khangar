using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_from_deposite_and_withdrawal_using_abstract
{
    abstract class Account
    {
        public abstract void deposite();
        public abstract void withdrwal();
    }

    class saving: Account
    {
        public override void deposite() 
        {
            Console.WriteLine("Hello form deposite method");
        }

        public override void withdrwal()
        {
            Console.WriteLine("Hello from withdrawl method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new saving();
            act.deposite();
            act.withdrwal();
            Console.ReadKey();
        }
    }
}
