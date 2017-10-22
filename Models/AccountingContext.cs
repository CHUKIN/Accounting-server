using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Accounting_server
{
    public class AccountingContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<User> Users { get; set; }
 
        public AccountingContext(DbContextOptions<AccountingContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseItem>()
                .HasKey(c => new { c.PurchaseId, c. ItemId });

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}