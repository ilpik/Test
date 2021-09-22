using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class MultipleLogWriter : ILogWriter
    {
        private IEnumerable<ILogWriter> LogWriters { get; set; }
        private MessageFormatter MessageFormatter { get; set; }
        public MultipleLogWriter( params ILogWriter[] logWriters)
        {
            LogWriters = logWriters;
        }
        
        public void LogInfo(string message)
        {
            MessageFormatter = new MessageFormatter();
            string mes = MessageFormatter.FormatMessage(message, Enum.LogLevel.Info);
            foreach (var writer in LogWriters)
            {
                writer.LogInfo(mes);
            }
        }

        public void LogWarning(string message)
        {
            string mes = MessageFormatter.FormatMessage(message, Enum.LogLevel.Warning);
            foreach (var writer in LogWriters)
            {
                writer.LogWarning(mes);
            }
        }

        public void LogError(string message)
        {
            string mes = MessageFormatter.FormatMessage(message, Enum.LogLevel.Error);
            foreach (var writer in LogWriters)
            {
                writer.LogError(mes);
            }
        }
    }
}
