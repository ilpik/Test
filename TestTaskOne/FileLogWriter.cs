using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class FileLogWriter : ILogWriter
    {
        private string _writePath;
        private IMessageFormatter _formatter;
        public FileLogWriter(string writePath, IMessageFormatter formatter)
        {
            _writePath = writePath;
            _formatter = formatter;
        }

        public void LogInfo(string message)
        {
            WriteInFile(message,LogLevel.Info);
        }

        public void LogWarning( string message)
        {
            WriteInFile(message, LogLevel.Warning);
        }

        public void LogError( string message)
        {
            WriteInFile(message, LogLevel.Error);
        }

        private void WriteInFile(string message, LogLevel logLevel)
        {
            File.AppendAllText(_writePath, _formatter.FormatMessage(message, logLevel) + "\r\n");
        }
    }
}
