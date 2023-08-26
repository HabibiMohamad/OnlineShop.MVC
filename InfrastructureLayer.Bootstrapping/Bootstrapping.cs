using ApplicationLayer.UseCases.Contracts;
using ApplicationLayer.UseCases.Implementations;
using DomainLayer.DomainServices.Repositories.Contracts; 
using InfrastructureLayer.Implementations_Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureLayer.Bootstrapping
{
    public class Bootstrapping
    {
        public static void WireUp(IServiceCollection service, string connectionString)
        {
            service.AddDbContext<OnlineShopDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });

            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

            service.AddScoped<IProductUseCase, ProductUseCase>();
            service.AddScoped<IProductCategoryUseCase, ProductCategoryUseCase>();              
        }
    }
}
