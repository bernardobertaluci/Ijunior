namespace Task03
{
    internal class MultiLogger : ILogger
    {
        private readonly ILogger[] _loggers;

        public MultiLogger(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void Log(string message)
        {
            foreach (ILogger logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }
}
