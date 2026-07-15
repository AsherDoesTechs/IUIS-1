using System;
using System.IO;

namespace IUIS.Utilities
{
    public static class Logger
    {
        public static void Log(string message)
        {
            string path = "Logs/error_log.txt";
            Directory.CreateDirectory("Logs");
            File.AppendAllText(path, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}