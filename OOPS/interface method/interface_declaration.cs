using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_declaration
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string errorMessage);
       
    }

    class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.LogMessage("Log in succesfully...");
            logger.LogError("Can't log into account !");

            Console.ReadKey();
        }
    }
}
