using System;

namespace TestTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+FFFF");

            FileLogWriter fileWriter = new FileLogWriter(date);
            ConsoleLogWriter consoleWriter = new ConsoleLogWriter(date);
            MultipleLogWriter multipleWriter = new MultipleLogWriter(consoleWriter, fileWriter);

            multipleWriter.LogInfo("InfoMessage");
            multipleWriter.LogError("ErrorMessage");
            multipleWriter.LogWarning("WarningMessage");
        }
    }
}
