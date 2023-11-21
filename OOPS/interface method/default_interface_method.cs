using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_interface_method
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string errorMessage);
        public void LogInfo(string infoMessage); // default interface method
      
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

        public void LogInfo(string infoMessage)
        {
            Console.WriteLine(infoMessage);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.LogMessage("Log in succesfully...");
            logger.LogError("Can't log into account !");
            logger.LogInfo("Default Logging infromation");

            Console.ReadKey();
        }
    }
}
