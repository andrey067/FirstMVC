using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Models
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context(DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SaSalesRecord { get; set; }
    }
}
