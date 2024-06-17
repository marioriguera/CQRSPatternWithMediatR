using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infraestructure.Data
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        /// <inheritdoc/>
        ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
        {
            // ApplicationDbContext.ReadAppSettings(); // settings = AppSettingsReader.ReadAppSettings();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // optionsBuilder.UseSqlServer(ApplicationDbContext.Current?.ConnectionString ?? $"Connection string its null.");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
