using DependencyInjection.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string info)
        {
            ConsoleColor color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.DarkCyan;

            System.Console.WriteLine(info);

            System.Console.ForegroundColor = color;
        }

        public void LogError(string error)
        {
            ConsoleColor color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine(error);

            System.Console.ForegroundColor = color;
        }

        public void LogError(Exception exception)
        {
            LogError(exception.Message);
        }
    }
}
