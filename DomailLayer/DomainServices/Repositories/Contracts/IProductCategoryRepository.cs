using DomainLayer.Domain;

namespace DomainLayer.DomainServices.Repositories.Contracts
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAll();
        ProductCategory GetById(int id);
        void Remove(int id);
        void Remove(ProductCategory category);
        void Add(ProductCategory category);  
        void Update(ProductCategory category);
    }
}
