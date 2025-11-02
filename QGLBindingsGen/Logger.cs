// Licensed under the MIT License. Copyright (c) 2025 vlOd
// Refer to the LICENSE file for more information

using System.Text;

namespace QGLBindingsGen;

public class Logger
{
    public static List<LogTarget> Targets = [];

    public enum LogLevel
    {
        INFO,
        WARN,
        ERROR
    }

    public delegate void LogTarget(string log, bool error, ConsoleColor color);

    static Logger() 
    {
        void WriteColored(object obj, ConsoleColor color, bool stdErr = false)
        {
            Console.ForegroundColor = color;
            if (stdErr)
                Console.Error.WriteLine(obj);
            else
                Console.WriteLine(obj);
            Console.ResetColor();
        }
        Targets.Add((log, error, color) => 
        {
            if (error)
                WriteColored(log, ConsoleColor.Red, true);
            else
                WriteColored(log, color);
        });
    }

    public static void Log(string header, string body, bool error = false, ConsoleColor color = ConsoleColor.Blue)
    {
        StringBuilder builder = new();
        builder.Append(DateTime.Now.ToString("HH:mm:ss"));
        builder.Append(" [");
        builder.Append(header);
        builder.Append("] ");
        builder.Append(body);

        lock (Targets) 
        {
            string log = builder.ToString();
            foreach (LogTarget target in Targets)
                target(log, error, color);
        }
    }

    private static ConsoleColor GetLevelColor(LogLevel level) => level switch
    {
        LogLevel.INFO => ConsoleColor.Blue,
        LogLevel.WARN => ConsoleColor.Yellow,
        LogLevel.ERROR => ConsoleColor.Red,
        _ => throw new ArgumentException(null, nameof(level))
    };

    public static void Log(LogLevel level, string body) => Log(level.ToString(), body, level >= LogLevel.ERROR, GetLevelColor(level));

    public static void Log(LogLevel level, string body, Exception exception)
    {
        StringBuilder builder = new();
        builder.Append(body);
        builder.Append(Environment.NewLine);
        builder.Append(exception.ToString());
        Log(level.ToString(), builder.ToString(), level >= LogLevel.ERROR, GetLevelColor(level));
    }

    public static void Info(string log) => Log(LogLevel.INFO, log);

    public static void Warn(string log) => Log(LogLevel.WARN, log);

    public static void Error(string log) => Log(LogLevel.ERROR, log);
}
