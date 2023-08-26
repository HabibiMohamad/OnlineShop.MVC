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



        Detail_ProductCategoryDetailDto GetDetail (int  id);



        List<GetAllForGrid_ProductCategoryDto> GetAllForGrid ();


        void Delete(int id);


        Update_ProductCategoyDto GetEdit(int id);
        void Update(Update_ProductCategoyDto dto);
    }
}
