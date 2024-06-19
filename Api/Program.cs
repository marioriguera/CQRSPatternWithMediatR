using Api.Middlewares;
using Application;
using Infraestructure.Persistence;

namespace Api
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to configure and run the web application.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Load appsettings.json configuration
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Add services to the container.
            builder.Services.AddPresentation()
                            .AddApplication()
                            .AddInfraestrucutre(configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}
