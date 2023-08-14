using ApplicationLayer.Dtos.ProductCategoryDtos;
using ApplicationLayer.UseCases.Contracts;
using DomailLayer.Domain;
using DomailLayer.DomainServices.Repositories.Contracts;


namespace ApplicationLayer.UseCases.Implementations
{
    public class ProductCategoryUseCase : IProductCategoryUseCase
    {
        private readonly IProductCategoryRepository _repository;

        public ProductCategoryUseCase(IProductCategoryRepository repository)
        {
            _repository = repository;

        }
        
        public List<GetAllForGrid_ProductCategoryDto> GetAllForGrid()
        {
            List<ProductCategory> productCategories = _repository.GetAll();
            var listDto= new List<GetAllForGrid_ProductCategoryDto>();
            foreach (var productCategory in productCategories)
            {
                var dto=new GetAllForGrid_ProductCategoryDto();
                dto.Id = productCategory.Id;
                dto.Title = productCategory.Title;
                listDto.Add(dto);
            }
            return listDto;        
        }
        public Detail_ProductCategoryDetailDto Detail(int id)
        {
            var productCategory = _repository.GetById(id);
            var dto= new Detail_ProductCategoryDetailDto();
            dto.Id = productCategory.Id;
            dto.Title = productCategory.Title;
            dto.Description = productCategory.Description;
            return dto;
        }
        public void Create(Create_PrductCategoryDto dto)
        {
            var productCategory=new ProductCategory();
            productCategory.Id = dto.Id;
            productCategory.Title = dto.Title;
            productCategory.Description = dto.Description;
            _repository.Add(productCategory);
        }
        public void Update (Uppdate_ProductCategoyDto dto)
        {
            var productCategory=new ProductCategory();
            productCategory.Id=dto.Id;
            productCategory.Title = dto.Title;
            productCategory.Description = dto.Description;
            _repository.Update(productCategory);
        }

        public List<GetAllForGrid_ProductCategoryDto> GetAllForGrid(int id)
        {
            throw new NotImplementedException();
        }
    }

}
