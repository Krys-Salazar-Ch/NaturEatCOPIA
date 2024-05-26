using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MyBbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order_Confirmation> Orders_confirmations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(products => products.Categories)
                .WithMany(Categories => Categories.Products);

            modelBuilder.Entity<Order_Confirmation>()
                .HasOne(order=>order.Customers)
                .WithMany(Customer => Customer.Order_Confirmation);

            modelBuilder.Entity<Order_Confirmation>()
               .HasMany(order => order.Products)
               .WithOne(products=>products.Order_Confirmation);
        }
    }
}
