using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            WriteInConsole(message);
        }

        public void LogWarning(string message)
        {
            WriteInConsole(message);
        }

        public void LogError(string message)
        {
            WriteInConsole(message);
        }

        private void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
