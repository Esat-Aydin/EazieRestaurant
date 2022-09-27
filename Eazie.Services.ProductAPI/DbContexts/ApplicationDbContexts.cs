using Eazie.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Eazie.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContexts : DbContext
    {
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
