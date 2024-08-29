using ELDOKKAN.Models;

namespace ELDOKKAN.Context;
public class EldokkanContext : DbContext
{
    // public AppContext(DbContextOptions<AppContext> options)
    //     : base(options)
    // {
    // }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = "Data Source = . ; initial Catalog = Eldokkan ; integrated security = true ; encrypt = false";
            optionsBuilder.UseSqlServer(connectionString);
        }
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
 }