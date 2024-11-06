using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EFTEST;

public class AppDbContext : DbContext
{
    public DbSet <Customer> YourEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=eftest;Username=tyler;Password=password");
    }
}

public class Customer
{
    [Key]
    public string account_id { get; set; }
    public string email_address { get; set; }
    public string account_type { get; set; }
    public int annual_fee { get; set; }
    public double total_amount_spent { get; set; }
    public string type_of_nonprofit { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DisplayCustomers();
    }

    static void DisplayCustomers()
    {
        using (var db = new AppDbContext())
        {
            var customers = db.YourEntities.ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.account_id);
            }
        }
    }

    static void CreateCustomer
    (
        string account_id,
        string email_address,
        string account_type,
        int annual_fee,
        double total_amount_spent,
        string type_of_nonprofit
    )
    {
        using (var context = new AppDbContext())
        {
            var customer = new Customer
            {
                account_id = account_id,
                email_address = email_address,
                account_type = account_type,
                annual_fee = annual_fee,
                total_amount_spent = total_amount_spent,
                type_of_nonprofit = type_of_nonprofit
            };

            context.YourEntities.Add(customer);
            context.SaveChanges();
        }

        Console.WriteLine("Customer created!");
    }
}