using System;
using System.IO;

public class SimpleLogger
{
    private string _logFilePath;

    public SimpleLogger(string logFilePath = "log.txt")
    {
        _logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
    }
}