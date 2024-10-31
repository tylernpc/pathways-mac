namespace LoggerApp
{
    internal class ProductService
    {
        private readonly ILogger _logger;

        public ProductService(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessOrder(string message)
        {
            _logger.Log(message);
        }
    }

}
