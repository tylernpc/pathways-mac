namespace LoggerApp
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to database: " + message);
        }
    }
}
