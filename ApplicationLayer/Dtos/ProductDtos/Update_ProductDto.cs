namespace ApplicationLayer.Dtos.ProductDtos
{
    public class Update_ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        // foreign key
        public int ProductCategoryId { get; set; }
    }
}
