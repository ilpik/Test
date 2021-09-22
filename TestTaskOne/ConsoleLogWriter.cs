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
            WriteInConsole(_formatter.FormatMessage(message, LogLevel.Info));
        }

        public void LogWarning(string message)
        {
            WriteInConsole(_formatter.FormatMessage(message, LogLevel.Warning));
        }

        public void LogError(string message)
        {
            WriteInConsole(_formatter.FormatMessage(message, LogLevel.Error));
        }

        private void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
