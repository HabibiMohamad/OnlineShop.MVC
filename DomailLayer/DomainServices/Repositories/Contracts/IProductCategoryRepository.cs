using DomainLayer.Domain;

namespace DomainLayer.DomainServices.Repositories.Contracts
{
    public interface IProductCategoryRepository
    {
        public List<ProductCategory> GetAll();
        public ProductCategory GetById(int id);
        public void Remove(int id);
        public void Remove(ProductCategory category);
        public void Add(ProductCategory category);  
        public void Update(ProductCategory category);
    }
}
