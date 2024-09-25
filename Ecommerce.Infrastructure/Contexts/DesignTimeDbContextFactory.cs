using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Contexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("server=TT-BACK-END-07\\SQLEXPRESS;database=ecommerce;uid=sa;password=admin@123;TrustServerCertificate=True;Encrypt=True"); 

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
