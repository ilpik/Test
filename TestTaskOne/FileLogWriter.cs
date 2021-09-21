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
        private string Date { get; set; }
        private string MessageType { get; set; }
        public FileLogWriter(string date)
        {
            Date = date;
        }

        public void LogInfo(string message)
        {
            MessageType = "Info";
            WriteInFile( MessageType, message);
        }

        public void LogWarning( string message)
        {
            MessageType = "Warning";
            WriteInFile(MessageType, message);
        }

        public void LogError( string message)
        {
            MessageType = "Error";
            WriteInFile(MessageType, message);
        }

        private void WriteInFile( string messageType, string message)
        {
         var writePath = @"..\\..\\..\\log.txt";
         var logString = $"{Date}    {messageType}   {message}";

         try
         {
             using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
             {
                 sw.WriteLine(logString);
             }

             //Console.WriteLine("Запись выполнена");
         }
         catch (Exception e)
         {
             Console.WriteLine(e.Message);
         }
        }
    }
}
