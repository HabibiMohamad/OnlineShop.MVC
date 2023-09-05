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
        List<GetAllForGrid_ProductCategoryDto> GetAllForGrid();
        List<GetAllForGrid_ProductCategoryDto> GetAllForBox();

        void Create(Create_ProductCategoryDto dto);


        Detail_ProductCategoryDetailDto GetDetail (int  id);

        void Delete(int id);

        Update_ProductCategoyDto GetEdit(int id);
        void Update(Update_ProductCategoyDto dto);
    }
}
