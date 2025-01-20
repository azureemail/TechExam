namespace TechExam.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        // Navigation property (collection of products)
        public ICollection<Product> Products { get; set; }
    }

    public class PageSizeAndNumber
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }

    public class PaginatedProductsDto
    {
        public string Message { get; set; }
        public List<ProductDto> Data { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalProducts { get; set; }
    }
}
