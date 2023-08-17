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
        void Create(Create_ProductDto dto);
        Detail_ProductDetailDto Detail(int id);
        List<GetAllForGrid_ProductDto> GetAllForGrid();
        void Update(Uppdate_ProductDto dto);
    }
}
