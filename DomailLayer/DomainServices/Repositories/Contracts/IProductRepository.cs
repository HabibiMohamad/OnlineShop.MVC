using DomainLayer.Domain;

namespace DomainLayer.DomainServices.Repositories.Contracts
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Remove(int id);
        public void Remove(Product product);
        public void Add(Product product);
        public void Update(Product product);
    }
}
