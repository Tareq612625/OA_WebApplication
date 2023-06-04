using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            #region Service Injected
                services.AddScoped(typeof(IRepository< >), typeof(Repository< >));
                services.AddScoped<IProductService, ProductService>();
            #endregion

            return services;
        }
    }
}
