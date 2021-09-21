using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOne
{
    public class MultipleLogWriter : ILogWriter
    {
        private ConsoleLogWriter ConsoleLogWriter { get; set; }
        private FileLogWriter FileLogWriter { get; set; }


        public MultipleLogWriter(ConsoleLogWriter consoleWriter, FileLogWriter fileWriter)
        {
            ConsoleLogWriter = consoleWriter;
            FileLogWriter = fileWriter;
        }

        public void LogInfo(string message)
        {
            ConsoleLogWriter.LogInfo("Info message in Console");
            FileLogWriter.LogInfo("Info message in File");
        }

        public void LogWarning(string message)
        {
            ConsoleLogWriter.LogWarning("Warning message in Console");
            FileLogWriter.LogWarning("Warning message in File");
        }

        public void LogError(string message)
        {
            ConsoleLogWriter.LogError("Error message in Console");
            FileLogWriter.LogError("Error message in File");
        }
    }
}
