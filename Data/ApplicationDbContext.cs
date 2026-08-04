using GhostShoes_Art_Site.Models;
using Microsoft.EntityFrameworkCore;

namespace GhostShoes_Art_Site.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CommissionInquiry> CommissionInquiries => Set<CommissionInquiry>();
    }
}