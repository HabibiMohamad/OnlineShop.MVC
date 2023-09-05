using ApplicationLayer.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.UseCases.Contracts
{
    public interface IProductUseCase
    {
        List<GetAllForGrid_ProductDto> GetAllForGrid();

        void Create(Create_ProductDto dto);

        Detail_ProductDetailDto Detail(int id);


        Update_ProductDto GetEdit(int id);
        void Update(Update_ProductDto dto);

        void Delete(int id);
    }
}
