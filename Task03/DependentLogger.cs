namespace Task03
{
    internal class DependentLogger : ILogger, IDayLogger
    {
        private readonly ILogger _logger;

        public DependentLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            if(IDayLogger.CanWrite())
                _logger.Log(message);
        }
    }
}
