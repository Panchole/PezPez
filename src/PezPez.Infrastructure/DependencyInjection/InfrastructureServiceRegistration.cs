using Microsoft.EntityFrameworkCore;
using PezPez.Infrastructure.Persistence.Contexts;
using PezPez.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PezPez.Application.Interfaces;
using PezPez.Infrastructure.Repositories;

namespace PezPez.Infrastructure.DependencyInjection;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PezPezDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}