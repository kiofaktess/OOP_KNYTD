using System;
using System.IO;
using System.Text;

namespace SingletonLogger
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());
        private readonly string _logFilePath;
        private Logger()
        {
            _logFilePath = "app.log";
        }
        public static Logger Instance => _instance.Value;
        public void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            Console.WriteLine(logEntry);
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
        }
        public void Info(string message) => Log($"INFO: {message}");
        public void Warning(string message) => Log($"WARNING: {message}");
        public void Error(string message) => Log($"ERROR: {message}");

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Logger.Instance.Info("Додаток запустився");
            Logger.Instance.Warning("Пам'ять майже заповнена");
            Logger.Instance.Error("Не вдалося під'єднатися до БД");
            Logger.Instance.Info("Застосунок завершив роботу");

            Console.WriteLine("Логи записані в app.log");
            Console.ReadLine();
        }
    }

}