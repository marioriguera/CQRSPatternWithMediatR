using Api.Middlewares;

namespace Api
{
    /// <summary>
    /// Provides extension methods for adding services to the dependency injection container.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Adds presentation layer services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
        /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<GlobalExceptionHandlingMiddleware>();
            return services;
        }
    }
}
