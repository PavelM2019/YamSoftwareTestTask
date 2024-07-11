using Microsoft.EntityFrameworkCore;
using YamSoftwareTestTaskREST_API.Models;

namespace YamSoftwareTestTaskREST_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
