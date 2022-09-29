using Eazie.Services.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eazie.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContexts : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options) : base(options)
        {

        }
    }
}
