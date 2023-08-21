using ApplicationLayer.Dtos.ProductCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.UseCases.Contracts
{
    public interface IProductCategoryUseCase
    {
        void Create(Create_ProductCategoryDto dto);
        Detail_ProductCategoryDetailDto Detail (int  id);
        List<GetAllForGrid_ProductCategoryDto> GetAllForGrid ();
        void Update(Uppdate_ProductCategoyDto dto);
        void Delete(int id);
    }
}
