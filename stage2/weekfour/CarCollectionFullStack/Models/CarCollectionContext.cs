using Microsoft.EntityFrameworkCore;

namespace CarCollectionFullStack.Models
{
    public class CarCollectionContext : DbContext
    {
        public CarCollectionContext(DbContextOptions<CarCollectionContext> options) 
            : base(options)
        { }

        public DbSet<CarItem> TodoItems { get; set; } = null!;
    }
}
