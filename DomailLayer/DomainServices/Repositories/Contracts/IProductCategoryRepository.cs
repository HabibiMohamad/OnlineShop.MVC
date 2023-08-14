using DomailLayer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomailLayer.DomainServices.Repositories.Contracts
{
    internal interface IProductCategoryRepository
    {
        public List<ProductCategory> GetAll();
        public ProductCategory GetById(int id);
        public void Remove(int id);
        public void Remove(ProductCategory category);
        public void Add(ProductCategory category);  
        public void Update(ProductCategory category);
    }
}
