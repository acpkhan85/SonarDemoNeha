using mysql.Application.Contracts.Persistence;
using mysql.Infrastructure.EncryptDecrypt;
using mysql.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace mysql.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("ApplicationConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();

            return services;    
        }
    }
}
