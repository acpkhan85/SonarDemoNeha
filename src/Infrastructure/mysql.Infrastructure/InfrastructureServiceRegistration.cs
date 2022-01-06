using mysql.Application.Contracts.Infrastructure;
using mysql.Application.Models.Cache;
using mysql.Application.Models.Mail;
using mysql.Infrastructure.Cache;
using mysql.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendGrid.Extensions.DependencyInjection;

namespace mysql.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();
            services.Configure<CacheConfiguration>(configuration.GetSection("CacheConfiguration"));
            services.AddMemoryCache();
            services.AddTransient<ICacheService, MemoryCacheService>();
            services.AddSendGrid(options => { options.ApiKey = configuration.GetValue<string>("EmailSettings:ApiKey"); });
            return services;
        }
    }
}
