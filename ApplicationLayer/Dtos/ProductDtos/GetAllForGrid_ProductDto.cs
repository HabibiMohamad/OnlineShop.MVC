namespace ApplicationLayer.Dtos.ProductDtos
{
    public class GetAllForGrid_ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }

        // title foreign key ro mikhaym int=>string
        // niaz be include darad
        public string ProductCategoryTitle { get; set; }
    }
}
