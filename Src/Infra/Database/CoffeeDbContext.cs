using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options) : base(options)
        {
        }
    }
}