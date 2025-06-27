using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Railwaiy_Eproject.Models;

namespace Railwaiy_Eproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Station> Station { get; set; }
        public DbSet<Train> Train { get; set; }
        public DbSet<Scheduling> Scheduling { get; set; }

    }
}
