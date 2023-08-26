using DomainLayer.Domain;
using DomainLayer.DomainServices.Repositories.Contracts;

namespace InfrastructureLayer.Implementations_Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly OnlineShopDbContext _dbContext;
        public ProductCategoryRepository(OnlineShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(ProductCategory category)
        {
            _dbContext.ProductCategories.Add(category);
        }

        public List<ProductCategory> GetAll()
        {
            var productCategories = _dbContext.ProductCategories.ToList();    
            return productCategories;
        }

        public ProductCategory GetById(int id)
        {
            var productCategoty = _dbContext.ProductCategories.Find(id);
            return productCategoty;
        }
        public void Remove(ProductCategory category)
        {
            _dbContext.ProductCategories.Remove(category);
        }

        public void Remove(int id)
        {
            var productCategory = _dbContext.ProductCategories.Find(id);
            _dbContext.ProductCategories.Remove(productCategory);
        }


        public void Update(ProductCategory category)
        {
           _dbContext.ProductCategories.Update(category);
        }
    }
}
