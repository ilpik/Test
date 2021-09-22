using System;

namespace TestTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var writePath = @"..\..\..\log.txt";
            MessageFormatter formatter = new MessageFormatter();

            FileLogWriter fileWriter = new FileLogWriter(writePath, formatter);
            ConsoleLogWriter consoleWriter = new ConsoleLogWriter(formatter);
            MultipleLogWriter multipleWriter = new MultipleLogWriter(consoleWriter, fileWriter);
            
            multipleWriter.LogInfo("Информация");
            multipleWriter.LogError("Ошибка");
            multipleWriter.LogWarning("Предупреждение");
        }
    }
}
