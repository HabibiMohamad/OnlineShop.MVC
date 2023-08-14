using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomailLayer.Domain
{
    // One
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

    }
}
