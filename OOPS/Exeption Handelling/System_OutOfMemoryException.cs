using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_OutOfMemoryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "sujit";
            string subject = "physics";

            Console.WriteLine("charachter Length: " + studentName.Length);

            StringBuilder sb = new StringBuilder(studentName.Length, studentName.Length);
        //  StringBuilder sb = new StringBuilder(capacity of string, maximum capacity of string);
            try
            {
                sb.AppendLine(subject);
                
            }
            catch(OutOfMemoryException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");

            Console.ReadKey();
        }
    }
}
