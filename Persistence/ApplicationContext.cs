using Microsoft.EntityFrameworkCore;

namespace BasicWebAPI.Repository
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {  }

        public DbSet<Car> Cars { get; set; }
    }
}