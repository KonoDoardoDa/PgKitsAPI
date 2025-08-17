using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PgKits.Application.Interfaces;
using PgKits.Application.Services;
using PgKits.Infrastructure.Persistence;
using PgKits.Infrastructure.Persistence.Repositories;

namespace PgKits.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<ItemRepository, ItemRepository>();
            services.AddScoped<IKitRepository, KitRepository>();
            return services;
        }
    }
}
