using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_class_for_interface_method
{
    interface Bank
    {
        void deposite(int actno, int amount);   
    }

    class Saving : Bank
    { 
        public void deposite(int actno, int amount)
        {
            int balance = 5000;
            int intrest = 200;
            balance = balance + amount + intrest;

            Console.WriteLine("Available Balance for the Account {0} is {1}.Rs ", actno, balance);
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Saving();
            b.deposite(123, 500);

            Console.ReadKey();
        }
    }
}
