using System;
namespace ELECTRICITYBILL
{
    class Bill
    {
        public static void Main(string[] args)
        {
            int CID, unit;
            string name;
            float total, surchrg = 0, finalamt = 0, chrg = 0;

            Console.WriteLine("\n ------------ ENTER ELECTRICITY BILL DETAILS ------------ \n");
            Console.Write("Enter Customer ID: ");
            CID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            name = Console.ReadLine();
            Console.Write("Unit Consumed: ");
            unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ------------ BILL PAID DETAILS ------------ \n");

            {
                if ( unit < 200 )
                {
                    chrg = 1.20f;
                }

                else if (unit >= 200 && unit < 400)
                {
                    chrg = 1.50f;
                }

                else if (unit >= 400 && unit < 600)
                {
                    chrg = 1.80f;
                }
                else
                {
                    chrg = 2.00f;
                }

                total = unit * chrg;

                Console.WriteLine("Customer ID: {0} \nCustomer Name: {1} \nUnit Consumed: {2}", CID, name, unit);
                Console.WriteLine("Amount Charges @Rs." + chrg + " per unit: Rs." + total);

            }

            if (total >= 400 )
            {
                surchrg = total * 0.15f;
            }

            finalamt = total + surchrg;

            finalamt = Math.Max(finalamt, 100.0f); // when 0 unit is consume then minimum bill is 100.Rs

            Console.WriteLine("Surchage Amount: Rs.{0} \nNet Amount Paid By the Customer: Rs.{1} ", surchrg, finalamt);
            Console.ReadKey();
        }
    }
}