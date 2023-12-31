﻿using DomainLayer.Domain;
using DomainLayer.DomainServices.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Implementations_Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShopDbContext _dbContext;

        public ProductRepository(OnlineShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            var products = _dbContext.Products.Include(e=>e.ProductCategory).ToList();
            return products;
        }

        public Product GetById(int id)
        {
            var product = _dbContext.Products.Find(id);
            return product;
        }
        public void Remove(Product product)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var product =_dbContext.Products.Find(id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }
    }
}
