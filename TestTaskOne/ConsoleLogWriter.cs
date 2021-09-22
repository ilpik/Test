using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class ConsoleLogWriter : ILogWriter, IMessageFormatter
    {
        public void LogInfo(string message)
        {
            var mes = FormatMessage(message, LogLevel.Info);
            WriteInConsole(mes);
        }

        public void LogWarning(string message)
        {
            var mes = FormatMessage(message, LogLevel.Warning);
            WriteInConsole(mes);
        }

        public void LogError(string message)
        {
            var mes = FormatMessage(message, LogLevel.Error);
            WriteInConsole(mes);
        }

        private void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }
        public string FormatMessage(string message, LogLevel logLevel)
        {
            string level = logLevel switch
            {
                LogLevel.Info => "Info",
                LogLevel.Error => "Error",
                LogLevel.Warning => "Warning"
            };
            return $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss+FFFF}\t{level}\t{message}";
        }
    }
}
