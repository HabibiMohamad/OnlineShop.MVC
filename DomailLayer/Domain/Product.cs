using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Domain
{
    // One
    public class Product
    {
        // field or property
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        // foreign key
        public int ProductCategoryId { get; set; }

        // navigation property
        public ProductCategory ProductCategory { get; set; }

    }
}
