using ApplicationLayer.Dtos.ProductDtos;
using ApplicationLayer.UseCases.Contracts;
using DomainLayer.Domain;
using DomainLayer.DomainServices.Repositories.Contracts;

namespace ApplicationLayer.UseCases.Implementations
{
    public class ProductUseCase : IProductUseCase
    {
        private readonly IProductRepository _repository;
        public ProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Create(Create_ProductDto dto)
        {
            var product = new Product();
            product.Id = dto.Id;
            product.Title = dto.Title;
            product.UnitPrice = dto.UnitPrice;
            product.Price = dto.Price;
            product.ProductCategoryId = dto.ProductCategoryId;
            _repository.Add(product);
        }

        public Detail_ProductDetailDto Detail(int id)
        {
            var product = _repository.GetById(id);
            var dto = new Detail_ProductDetailDto();
            dto.Id = product.Id;
            dto.Title = product.Title;
            dto.UnitPrice = product.UnitPrice;
            dto.Price = product.Price;
            dto.ProductCategoryId = product.ProductCategoryId;
            return dto;
        }

        public List<GetAllForGrid_ProductDto> GetAllForGrid()
        {
            List<Product> products = _repository.GetAll();
            
            // نکته ریز دارد
            // hatman bayad product ro be productCategory ba Include kardan vasl konam
            // ta NavigationProperty Product=>ProductCategory Por beshe
            var listDto = new List<GetAllForGrid_ProductDto>();
            foreach (var product in products)
            {
                var dto = new GetAllForGrid_ProductDto();
                dto.Id = product.Id;
                dto.Title = product.Title;
                dto.UnitPrice = product.UnitPrice;
                dto.Price = product.Price;
                dto.ProductCategoryTitle = product.ProductCategory.Title;
                listDto.Add(dto);
            }
            return listDto;
        }

        public void Update(Update_ProductDto dto)
        {
            var product = new Product();
            product.Id = dto.Id;
            product.Title = dto.Title;
            product.UnitPrice = dto.UnitPrice;
            product.Price = dto.Price;
            product.ProductCategoryId = dto.ProductCategoryId;

            _repository.Update(product);
        }
        public void Delete(int id)
        {
            _repository.Remove(id);
        }

        public Update_ProductDto GetEdit(int id)
        {
            var product = _repository.GetById(id);

            var dto = new Update_ProductDto();
            dto.Id = product.Id;
            dto.Title = product.Title;
            dto.UnitPrice = product.UnitPrice;
            dto.Price = product.Price;
            dto.ProductCategoryId = product.ProductCategoryId;

            return dto;
        }
    }
}
