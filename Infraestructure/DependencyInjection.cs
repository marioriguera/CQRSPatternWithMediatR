using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Persistence
{
    /// <summary>
    /// Provides extension methods for configuring dependency injection in the application.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Adds infrastructure-related services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <param name="configuration">The configuration for the application.</param>
        /// <returns>The <see cref="IServiceCollection"/> with the added services.</returns>
        public static IServiceCollection AddInfraestrucutre(this IServiceCollection services, IConfiguration configuration)
        {
            services.Scan(
                    selector => selector
                    .FromAssemblies(
                            InfraestructureAssemblyReference.Assembly)
                    .AddClasses(false)
                    .AsImplementedInterfaces()
                    .WithScopedLifetime()
                );

            services.AddDbContext<ApplicationDbContext>(
                options =>
                    options
                    .UseSqlServer(configuration
                    .GetConnectionString("SqlServer")));

            return services;
        }
    }
}
