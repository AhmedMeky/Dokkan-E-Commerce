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
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Admin configuration
        modelBuilder.Entity<Admin>()
            .HasKey(ad => ad.AdminID);
        modelBuilder.Entity<Admin>()
            .Property(ad=>ad.Email).IsRequired();
        modelBuilder.Entity<Admin>()
            .Property(ad => ad.Password).IsRequired();

        // Customer configuration
        modelBuilder.Entity<Customer>()
            .HasKey(c => c.CustomerID);

        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Orders)
            .WithOne(o => o.Customer)
            .HasForeignKey(o => o.CustomerID);


        // Order configuration
        modelBuilder.Entity<Order>()
            .HasKey(o => o.OrderID);

        modelBuilder.Entity<Order>()
            .HasMany(o => o.OrderDetails)
            .WithOne(od => od.Order)
            .HasForeignKey(od => od.OrderID);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerID);

        
        // OrderDetail configuration
        modelBuilder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderID, od.ProductID });

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderID);

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductID);


        // Product configuration
        modelBuilder.Entity<Product>()
            .HasKey(p => p.ProductID);

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryID);


        modelBuilder.Entity<Category>()
            .HasKey(c => c.CategoryID);
    }
}