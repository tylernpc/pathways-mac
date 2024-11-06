using Microsoft.EntityFrameworkCore;

namespace Membership;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public class TableCreator : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=customer;Username=tyler;Password=password");
        }
    }
}