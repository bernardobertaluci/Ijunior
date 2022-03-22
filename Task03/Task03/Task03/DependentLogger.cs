namespace Task03
{
    internal class DependentLogger : ILogger
    {
        private readonly ILogger _logger;
        private readonly IDayLogger _dayLogger;

        public DependentLogger(ILogger logger, IDayLogger dayLogger)
        {
            _logger = logger;
            _dayLogger = dayLogger;
        }

        public void Log(string message)
        {
            if(_dayLogger.CanWrite())
                _logger.Log(message);
        }
    }
}
