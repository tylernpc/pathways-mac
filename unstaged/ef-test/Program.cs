using Microsoft.EntityFrameworkCore;
namespace EFTEST;

public class AppDbContext : DbContext
{
    public DbSet <YourEntity> YourEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=your_host;Database=your_db;Username=tyler;Password=password");
    }
}

public class YourEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public YourEntity()
    {
        Id = 0;
        Name = "";
    }

    public YourEntity(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}