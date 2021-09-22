using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class FileLogWriter : ILogWriter, IMessageFormatter
    {
        private string WritePath { get; set; }

        public FileLogWriter(string writePath)
        {
            WritePath = writePath;
        }

        public void LogInfo(string message)
        {
            var mes = FormatMessage(message, LogLevel.Info);
            WriteInFile(mes);
        }

        public void LogWarning( string message)
        {
            var mes = FormatMessage(message, LogLevel.Warning);
            WriteInFile(mes);
        }

        public void LogError( string message)
        {
            var mes = FormatMessage(message, LogLevel.Error);
            WriteInFile(mes);
        }

        private void WriteInFile(string message)
        {
            File.AppendAllText(WritePath,message + "\r\n");
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
