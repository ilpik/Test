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
        private ILogWriter[] LogWriters { get; set; }
        public MultipleLogWriter( params ILogWriter[] logWriters)
        {
            LogWriters = logWriters;
        }
        
        public void LogInfo(string message)
        {
            foreach (var writer in LogWriters)
            {
                writer.LogInfo(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (var writer in LogWriters)
            {
                writer.LogWarning(message);
            }
        }

        public void LogError(string message)
        {
            foreach (var writer in LogWriters)
            {
                writer.LogError(message);
            }
        }
    }
}
