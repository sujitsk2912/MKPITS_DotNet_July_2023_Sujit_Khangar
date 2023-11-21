using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_class_for_saving_cureent_deposite_and_withdrawl
{
    interface Bank
    {
        void deposite(int actno, int amount);
        void withdrawl(int actno, int amount);
    }

    class Account
    {
       public int balance = 5000;
       public int intrest = 200;
    }

    class Saving : Account, Bank
    {
       
        public void deposite(int actno, int amount)
        {
            balance = balance + amount + intrest;
            Console.WriteLine("Amount Deposited succesfully, Available balance for Account " + actno + " is " + balance);
        }

        public void withdrawl(int actno, int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount Withdrawl succesfully, Available balance for Account " + actno + " is " + balance);
        }
    }

    class Current :Account, Bank
    {
        public void deposite(int actno, int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount Deposited succesfully, Available balance for Account " + actno + " is " + balance);
        }

        public void withdrawl(int actno, int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount Withdrawl succesfully, Available balance for Account " + actno + " is " + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank B = null;
            Console.WriteLine("Choose your account type (saving / current) : ");
            string acttype = Console.ReadLine();
           
            switch(acttype)
            {
                case "saving":
                    B = new Saving();
                    break;

                case "current":
                    B = new Current();
                    break;
            }

            Console.WriteLine("Do you want to Deposite or Withdrawl Money: ");
            string trasactiontype = Console.ReadLine();

           if(trasactiontype == "deposite")
            {
                B.deposite(123, 500);     
            }
           else if(trasactiontype == "withdrawl")
            {
                B.withdrawl(123, 500);
            }

           Console.ReadKey();
        }
    }
}
