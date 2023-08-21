﻿using ApplicationLayer.UseCases.Contracts;
using ApplicationLayer.UseCases.Implementations;
using DomailLayer.DomainServices.Repositories.Contracts; // Chere 2 tas ??
using DomainLayer.DomainServices.Repositories.Contracts; // Chere 2 tas ??
using InfrastructureLayer.Implementations_Repository_;
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