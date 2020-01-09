namespace iTechArt.Common.Logging
{
    public static class LoggerContext
    {
        private static ILogger _logger;


        public static ILogger Current
        {
            get => _logger ?? (_logger = new Logger("Default logger"));

            set => _logger = value;
        }
    }
}