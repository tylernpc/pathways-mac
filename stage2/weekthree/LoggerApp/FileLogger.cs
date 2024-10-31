namespace LoggerApp
{
    internal class FileLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to file: " + message);
        }
    }
}
