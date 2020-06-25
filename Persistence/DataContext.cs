using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<OrderItems>(x => x.HasKey(oi =>
                new { oi.OrderId, oi.ProductId}));

            builder.Entity<OrderItems>()
                .HasOne(o => o.Order)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(o => o.OrderId);

            builder.Entity<OrderItems>()
                .HasOne(p => p.Product)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(p => p.ProductId);
        }
    }
}