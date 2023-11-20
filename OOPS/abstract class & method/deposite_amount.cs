using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposite_amount_using_abstract
{
    abstract class Account
    {
        public abstract void deposite(int amount);
    }

    class saving: Account
    {
        public override void deposite(int amount) 
        {
            int balance = 1000;
            balance = balance + amount;
            Console.WriteLine("Amount deposited succesfully, Available balance is: " +  balance);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new saving();
            act.deposite(100);
            Console.ReadKey();
        }
    }
}
