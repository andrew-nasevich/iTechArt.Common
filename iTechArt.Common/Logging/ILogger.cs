using System;

namespace iTechArt.Common.Logging
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogTrace(string message);

        void LogWarn(Exception e, string message);

        void LogError(Exception e, string message);

        void LogFatal(Exception e, string message);
    }
}