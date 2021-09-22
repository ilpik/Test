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

        public FileLogWriter(string writePath)
        {
            WritePath = writePath;
        }

        public void LogInfo(string message)
        {
            WriteInFile(message);
        }

        public void LogWarning( string message)
        {
            WriteInFile(message);
        }

        public void LogError( string message)
        {
            WriteInFile(message);
        }

        private void WriteInFile(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(WritePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
