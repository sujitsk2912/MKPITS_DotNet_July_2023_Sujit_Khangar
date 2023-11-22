using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace @public
{
    public class emplyee
    {
        public int ID = 123;
        public string Name = "Sujit";

        public void display()
        {
            Console.WriteLine("Employee ID: " +  ID);
            Console.WriteLine("Employee Name: " +  Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emplyee emp = new emplyee();
            Console.WriteLine("Employee ID: " + emp.ID);
            Console.WriteLine("Employee Name: " + emp.Name);

            Console.ReadKey();
        }
    }
}
