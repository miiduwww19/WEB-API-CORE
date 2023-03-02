using DOMAIN.DATABASE;
using Microsoft.EntityFrameworkCore;

namespace WEB_API_CORE.ServicesExtenstion
{
    public static class ServiceExtenstion
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", bulider =>
                    bulider.AllowAnyHeader()
                        .AllowAnyOrigin()
                        .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureSqlContext(this IServiceCollection services, string connectionString)
            => services.AddDbContext<DatabaseContext>(p => p.UseSqlServer(connectionString));
    }
}
