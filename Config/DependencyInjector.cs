using Microsoft.Extensions.DependencyInjection;
using Sync.WebApi.Repository;
using Sync.WebApi.Services;

namespace Sync.WebApi.Config
{
    public class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<SyncApiDbContext>();

            services.AddScoped<ProductRepository>();

            services.AddScoped<ProductService>();
        }
    }
}