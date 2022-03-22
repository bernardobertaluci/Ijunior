using System.IO;

namespace Task03
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
