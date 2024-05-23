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
        public DbSet<Categories> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order_Confirmation> orders_confirmations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Order_Confirmation>() //relacion order-customer
            .HasOne(order => order.Customer)
            .WithMany(customer => customer.Order_Confirmation)
            .HasForeignKey(order => order.CustomerId);*/

             
           /* FALTA DE ADAPTAR
            * 
            * modelBuilder.Entity<Order_Confirmation>() //relación entre OrdenCompra y Producto
                .HasMany(oc => oc.Product)
                .WithOne(p => p.OrdenCompra)
                .HasForeignKey(p => p.OrdenCompraId);

            // Configuración de la relación entre Producto y Categoria
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId);*/


        }
    }
}
