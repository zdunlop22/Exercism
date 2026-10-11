// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Unknown=0,
    Trace=1,
    Debug=2,
    Info=4,
    Warning=5,
    Error=6,
    Fatal=42,
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        String parsedLevel=logLine.Substring(logLine.IndexOf("[")+1, 3);

        return parsedLevel switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        int value = (int)logLevel;
        return $"{value}:{message}";       
    }
}
