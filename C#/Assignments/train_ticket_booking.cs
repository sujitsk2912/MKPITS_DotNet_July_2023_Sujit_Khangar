using System;
namespace TRAIN_TICKET
{
    class Ticket
    {
        public static void Main(string[] args)
        {
            string pname, gender, PNR, date, Class, to, destination=null;
            int age,price=0, distance=0, Ngp=1;

            Console.WriteLine("\n ---------------- INDIAN RAILWAY CATERING AND TOURISM CORPORATION (IRCTC) ---------------- \n");

            Console.Write("Enter Passanger Name: ");
            pname = Console.ReadLine(); // Enter passanger name

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine()); // Enter Passenger age

            Console.Write("Gender: ");
            gender = Console.ReadLine(); // Enter your Gender

            Console.Write("Enter PNR No.: ");
            PNR = Console.ReadLine(); // Enter Train PNR number

            Console.Write("From: Ngp to - (Bhandara, Gondia, Mp, Banglore): "); // destination from - to
            to = Console.ReadLine();

            Console.Write("Class: Ac / Sleeper / General: "); // Compartment (Class) Ac, Sleeper, General
            Class = Console.ReadLine();

            Console.Write("Enter Date (DD/MM/YY) : ");
            date = Console.ReadLine(); // Enter Date

            destination = to;

            if (Ngp == Ngp && destination == "Bhandara"  )
            {
                price = 100;
            }
            else if (Ngp == Ngp && destination == "Gondia")
            {
                price = 200;
            }
            else if (Ngp == Ngp && destination == "Mp")
            {
                price = 500;
            }
            else if (Ngp == Ngp && destination == "Banglore")
            {
                price = 800;
            }
            else
            {
                Console.WriteLine("Invalid Destination");
            }

            Console.WriteLine("\n ---------------- BOOKING DETAIL'S ---------------- \n");
            Console.WriteLine(" Passanger Name: {0} \n Age: {1} \n Gender: {2} \n PNR No.: {3} \n Arrival From: Ngp - to: {4} \n Class: {5} \n Date: {6} \n Ticket Price: Rs.{7}", pname, age, gender, PNR, to, Class, date, price);
            Console.ReadKey();
        }
    }
}