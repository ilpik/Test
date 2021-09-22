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
        private string WritePath { get; set; }
        private IMessageFormatter _formatter { get; set; }
        public FileLogWriter(string writePath, IMessageFormatter formatter)
        {
            WritePath = writePath;
            _formatter = formatter;
        }

        public void LogInfo(string message)
        {
            WriteInFile((_formatter.FormatMessage(message, LogLevel.Info)));
        }

        public void LogWarning( string message)
        {
            WriteInFile((_formatter.FormatMessage(message, LogLevel.Warning)));
        }

        public void LogError( string message)
        {
            WriteInFile((_formatter.FormatMessage(message, LogLevel.Error)));
        }

        private void WriteInFile(string message)
        {
            File.AppendAllText(WritePath,message + "\r\n");
        }
    }
}
