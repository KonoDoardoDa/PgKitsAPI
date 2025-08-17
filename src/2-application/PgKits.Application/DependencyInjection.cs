using Microsoft.Extensions.DependencyInjection;
using PgKits.Application.Interfaces;
using PgKits.Application.Services;


namespace PgKits.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
