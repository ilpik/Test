using System;

namespace TestTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+FFFF");
            var writePath = @"..\\..\\..\\log.txt";

            FileLogWriter fileWriter = new FileLogWriter(writePath);
            ConsoleLogWriter consoleWriter = new ConsoleLogWriter();
            MultipleLogWriter multipleWriter = new MultipleLogWriter(consoleWriter, fileWriter);
            
            multipleWriter.LogInfo("Информация");
            multipleWriter.LogError("Ошибка");
            multipleWriter.LogWarning("Предупреждение");
        }
    }
}
