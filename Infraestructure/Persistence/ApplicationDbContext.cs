using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    internal sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(InfraestructureAssemblyReference.Assembly);
    }
}
