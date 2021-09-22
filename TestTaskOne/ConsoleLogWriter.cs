using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class ConsoleLogWriter : ILogWriter
    {
        private IMessageFormatter _formatter;
        public ConsoleLogWriter(IMessageFormatter messageFormatter)
        {
            _formatter = messageFormatter;
        }
        public void LogInfo(string message)
        {
            WriteInConsole(message, LogLevel.Info);
        }

        public void LogWarning(string message)
        {
            WriteInConsole(message, LogLevel.Warning);
        }

        public void LogError(string message)
        {
            WriteInConsole(message, LogLevel.Error);
        }

        private void WriteInConsole(string message, LogLevel logLevel)
        {
            Console.WriteLine(_formatter.FormatMessage(message, logLevel));
        }
        
    }
}
