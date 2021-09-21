using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class ConsoleLogWriter : ILogWriter
    { 
        private string MessageType { get; set; }
        private string Date { get; set; }

        public ConsoleLogWriter(string date)
        {
            Date = date;
        }

        public void LogInfo(string message)
        {
            MessageType = "Info";
            WriteInConsole(MessageType,message);
        }

        public void LogWarning(string message)
        {
            MessageType = "Warning";
            WriteInConsole(MessageType, message);
        }

        public void LogError(string message)
        {
            MessageType = "Error";
            WriteInConsole( MessageType, message);
        }

        private void WriteInConsole( string messageType, string message)
        {
            Console.WriteLine($"{Date}  {messageType}   {message}");
        }
    }
}
