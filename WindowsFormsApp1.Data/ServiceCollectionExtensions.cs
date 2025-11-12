using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1; 
using WindowsFormsApp1.Data.Repositories;
using WindowsFormsApp1.Data.Context;

namespace WindowsFormsApp1.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            // Enregistrer le DbContext et les repositories
            services.AddScoped<AppDbContext>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            




            return services;
        }
    }
}
