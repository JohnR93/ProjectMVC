using Microsoft.EntityFrameworkCore;

namespace ProjectMVC
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options){}

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>();
        }
    }
}