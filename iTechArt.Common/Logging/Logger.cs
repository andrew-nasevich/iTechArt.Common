using System;
using NLog;

namespace iTechArt.Common.Logging
{
    public class Logger : ILogger
    {
        private readonly NLog.Logger _logger;


        public Logger(string name)
        {
           _logger = LogManager.GetLogger(name);
        }


        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogTrace(string message)
        {
            _logger.Trace(message);
        }

        public void LogWarn(Exception e, string message)
        {
            _logger.Warn(e, message);
        }

        public void LogError(Exception e, string message)
        {
            _logger.Error(e, message);
        }

        public void LogFatal(Exception e, string message)
        {
            _logger.Fatal(e, message);
        }
    }
}