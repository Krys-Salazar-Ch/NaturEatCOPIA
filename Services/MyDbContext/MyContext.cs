using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services.MyBbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order_Confirmation> Orders_confirmations { get; set; }
        public DbSet<OrderDetails> DetailOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order_Confirmation>()
                .HasMany(od => od.OrderDetails)
                .WithOne(o => o.Order_Confirmation)
                .HasForeignKey(od => od.OrderConfirmationId);

            modelBuilder.Entity<Categories>()
                .HasMany(C => C.Products)
                .WithOne(P => P.Categories)
                .HasForeignKey(C => C.CategoriesId);

            modelBuilder.Entity<Order_Confirmation>()
                .HasOne(order => order.Customer)
                .WithMany(Customer => Customer.Order_Confirmation)
                .HasForeignKey(order => order.CustomerId);
        }
    }
}
