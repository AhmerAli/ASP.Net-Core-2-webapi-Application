using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace server.Data
{
    public class ApplicationDbContext : IdentityDbContext<EmployeeProfile>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
    }
}