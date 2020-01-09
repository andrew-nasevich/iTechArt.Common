using System;

namespace iTechArt.Common.Logging
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogTrace(string message);

        void LogWarn(string message, Exception e = null);

        void LogError(Exception e, string message);

        void LogFatal(Exception e, string message);
    }
}