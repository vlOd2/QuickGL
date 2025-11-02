using System.Diagnostics;

namespace QGLBindingsGen;

internal static class TaskRunner
{
    public static Dictionary<string, (long, long)> TaskTimings = [];

    public static async Task Run(string name, Task task)
    {
        long startTime = Stopwatch.GetTimestamp();
        Logger.Info(name);
        try
        {
            await task;
            TaskTimings[$"{name} ({task.GetHashCode():X})"] = (startTime, Stopwatch.GetTimestamp());
        }
        catch (Exception ex)
        {
            Logger.Error($"Task encountered an error: {ex.GetType().Name} -> {ex.Message}");
            throw;
        }
    }

    public static async Task<T> Run<T>(string name, Task<T> task)
    {
        long startTime = Stopwatch.GetTimestamp();
        Logger.Info(name);
        try
        {
            T result = await task;
            TaskTimings[$"{name} ({task.GetHashCode():X})"] = (startTime, Stopwatch.GetTimestamp());
            return result;
        }
        catch (Exception ex)
        {
            Logger.Error($"Task encountered an error: {ex.GetType().Name} -> {ex.Message}");
            throw;
        }
    }
}
