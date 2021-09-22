using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class MessageFormatter : IMessageFormatter
    {
        private string Level { get; set; }
        public string FormatMessage(string message, Enum.LogLevel logLevel)
        {
            switch(logLevel)
            {
                case Enum.LogLevel.Info:
                    Level = "Info";
                    break;
                
                case Enum.LogLevel.Error:
                    Level = "Error";
                    break;
                
                case Enum.LogLevel.Warning:
                    Level = "Warning";
                    break;
        };
            return $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss+FFFF}\t{Level}\t{message}";
        }

    }
}
