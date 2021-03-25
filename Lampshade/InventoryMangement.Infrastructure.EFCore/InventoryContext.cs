using InventoryManagement.Domain.InventoryAgg;
using InventoryManagement.Domain.Test;
using InventoryMangement.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace InventoryMangement.Infrastructure.EFCore
{
    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        
        // public DbSet<Author> Authors { get; set; }
        // public DbSet<Book> Books { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(InventoryMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);


            modelBuilder.ApplyConfiguration(new InventoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
