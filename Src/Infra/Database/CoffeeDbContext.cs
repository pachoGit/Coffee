using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public class CoffeeDbContext : DbContext
    {
        public DbSet<CoffeeProducer> CoffeeProducer { get; set; }

        public DbSet<BatchCoffeeProducer> BatchCoffeeProducer { get; set; }

        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options)
        {
        }
    }
}
