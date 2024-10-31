namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new DatabaseLogger();
            ProductService productService = new ProductService(logger);

            productService.ProcessOrder("Order processed successfully!");
        }
    }
}