using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class MessageFormatter : IMessageFormatter
    {
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
