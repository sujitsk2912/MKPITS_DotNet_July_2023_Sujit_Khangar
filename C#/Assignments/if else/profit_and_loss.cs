using System;
namespace RROFITLOSS
{
    class Loss
    {
        public static void Main(string[] args)
        {
            int cost, sell, profit=0, loss=0;
            Console.Write("Enter Cost Price: ");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Selling Price: ");
            sell = Convert.ToInt32(Console.ReadLine());

            if (cost < sell)
            {
                profit = sell - cost;
                Console.WriteLine("\nYou can book your profit amount: Rs. " + profit);
            }
            else if ( cost == sell)
            {
                 Console.WriteLine("\nNo Profit and Loss occures");
            }
            else
            {
                loss = cost - sell;
                Console.WriteLine("\nYou will loss amount: Rs. " + loss );
            }
            Console.ReadKey();
        }
    }
}