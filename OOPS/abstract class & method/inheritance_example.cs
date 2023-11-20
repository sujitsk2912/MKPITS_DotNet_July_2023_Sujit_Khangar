using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example
{
    class Vehicle
    {
        public void make(string company)
        {
            Console.WriteLine("Company: " + company);
        }

        public void model(string Model)
        {
            Console.WriteLine("Model: " + Model);
        }
    }

    class Car: Vehicle
    { 
        public void numDoors(int Doors)
        {
            Console.WriteLine("Numebrs of doors: " + Doors);
        }

        public void fuelType(string Fuel)
        {
           Console.WriteLine("Fuel Type: " + Fuel);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.make("TATA Motors");
            v.model("TATA SUV 2022");

            Car car = new Car();
            car.numDoors(4);
            car.fuelType("Petrol");

            Console.ReadKey();
        }
    }
}
