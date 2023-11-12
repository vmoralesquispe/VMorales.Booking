using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VMorales.Booking.Application.DataBase;
using VMorales.Booking.Persistence.DataBase;

namespace VMorales.Booking.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<DataBaseService>(options =>
            options.UseSqlServer(configuration["SQLConnectionStrings"]));

            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}
