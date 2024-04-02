using Microsoft.EntityFrameworkCore;

namespace AdvancedDatabaseWeek4
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

    }
}
