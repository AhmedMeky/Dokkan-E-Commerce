namespace ELDOKKAN.Context;
public class AppDbContext : DbContext
{
    // public AppContext(DbContextOptions<AppContext> options)
    //     : base(options)
    // {
    // }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("./AppSettings.json", optional: false, reloadOnChange: true)
                .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection")!;
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<Admin>(new AdminEntityTypeConfiguration())
            .ApplyConfiguration<Category>(new CategoryEntityTypeConfiguration())
            .ApplyConfiguration<Product>(new ProductEntityTypeConfiguration())
            .ApplyConfiguration<Order>(new OrderEntityTypeConfiguration())
            .ApplyConfiguration<Customer>(new CustomerEntityTypeConfiguration())
            .ApplyConfiguration<OrderDetails>(new OrderDetailsEntityTypeConfiguration());
    }
}
