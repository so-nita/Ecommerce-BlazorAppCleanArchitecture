using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Stadium> Stadiums { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
