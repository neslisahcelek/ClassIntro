using System;
namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            System.Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
