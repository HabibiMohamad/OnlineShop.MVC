using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Dtos.ProductCategoryDtos
{
    public class Create_ProductCategoryDto
    {
        // [] => Attribute
        // [Required] => Attribute Data Annotation


        //[Required]
        //[MinLength(5)]
        //[MaxLength(15)]
        //[EmailAddress]
        //[Phone]
        //[Range(5, 15)]

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}