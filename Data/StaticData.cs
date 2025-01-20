using System.Collections.Generic;
using TechExam.Models;

namespace TechExam.Data
{
    public static class StaticData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, CategoryName = "Electronics" },
            new Category { Id = 2, CategoryName = "Clothing" },
            new Category { Id = 3, CategoryName = "Books" },
            new Category { Id = 4, CategoryName = "Furniture" },
            new Category { Id = 5, CategoryName = "Toys" }
        };

        public static List<Product> Products = new List<Product>
        {
            // Electronics
            new Product { Id = 1, Name = "Smartphone", Price = 699.99M, Description = "Latest model with 128GB storage", CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Price = 1099.99M, Description = "High performance with 16GB RAM", CategoryId = 1 },
            new Product { Id = 3, Name = "Smartwatch", Price = 199.99M, Description = "Fitness tracker with heart rate monitor", CategoryId = 1 },
            new Product { Id = 4, Name = "Tablet", Price = 499.99M, Description = "10-inch screen with 64GB storage", CategoryId = 1 },
            new Product { Id = 5, Name = "Headphones", Price = 149.99M, Description = "Noise-cancelling wireless headphones", CategoryId = 1 },
            new Product { Id = 6, Name = "Camera", Price = 799.99M, Description = "DSLR camera with 24MP sensor", CategoryId = 1 },
            
            // Clothing
            new Product { Id = 7, Name = "T-shirt", Price = 19.99M, Description = "Cotton t-shirt with various colors", CategoryId = 2 },
            new Product { Id = 8, Name = "Jeans", Price = 49.99M, Description = "Denim jeans with slim fit", CategoryId = 2 },
            new Product { Id = 9, Name = "Jacket", Price = 89.99M, Description = "Leather jacket for winter", CategoryId = 2 },
            new Product { Id = 10, Name = "Sneakers", Price = 69.99M, Description = "Comfortable running shoes", CategoryId = 2 },
            new Product { Id = 11, Name = "Cap", Price = 14.99M, Description = "Stylish baseball cap", CategoryId = 2 },
            new Product { Id = 12, Name = "Socks", Price = 5.99M, Description = "Pair of athletic socks", CategoryId = 2 },

            // Books
            new Product { Id = 13, Name = "Science Fiction Novel", Price = 14.99M, Description = "A thrilling adventure in space", CategoryId = 3 },
            new Product { Id = 14, Name = "Programming Guide", Price = 29.99M, Description = "Learn C# in depth", CategoryId = 3 },
            new Product { Id = 15, Name = "History Textbook", Price = 24.99M, Description = "Detailed history of ancient civilizations", CategoryId = 3 },
            new Product { Id = 16, Name = "Mystery Novel", Price = 12.99M, Description = "A gripping detective story", CategoryId = 3 },
            new Product { Id = 17, Name = "Cookbook", Price = 19.99M, Description = "Delicious recipes from around the world", CategoryId = 3 },
            new Product { Id = 18, Name = "Travel Guide", Price = 16.99M, Description = "Explore popular destinations", CategoryId = 3 },

            // Furniture
            new Product { Id = 19, Name = "Sofa", Price = 499.99M, Description = "Comfortable 3-seater sofa", CategoryId = 4 },
            new Product { Id = 20, Name = "Dining Table", Price = 299.99M, Description = "Wooden dining table for 6", CategoryId = 4 },
            new Product { Id = 21, Name = "Chair", Price = 89.99M, Description = "Ergonomic office chair", CategoryId = 4 },
            new Product { Id = 22, Name = "Bed", Price = 799.99M, Description = "King-size bed with memory foam mattress", CategoryId = 4 },
            new Product { Id = 23, Name = "Bookshelf", Price = 199.99M, Description = "5-tier bookshelf in oak finish", CategoryId = 4 },
            new Product { Id = 24, Name = "Wardrobe", Price = 399.99M, Description = "Spacious wardrobe with sliding doors", CategoryId = 4 },

            // Toys
            new Product { Id = 25, Name = "Action Figure", Price = 19.99M, Description = "Collectible superhero action figure", CategoryId = 5 },
            new Product { Id = 26, Name = "Board Game", Price = 29.99M, Description = "Fun family board game", CategoryId = 5 },
            new Product { Id = 27, Name = "Puzzle", Price = 9.99M, Description = "1000-piece jigsaw puzzle", CategoryId = 5 },
            new Product { Id = 28, Name = "Toy Car", Price = 14.99M, Description = "Remote-controlled toy car", CategoryId = 5 },
            new Product { Id = 29, Name = "Doll", Price = 24.99M, Description = "Fashion doll with accessories", CategoryId = 5 },
            new Product { Id = 30, Name = "Building Blocks", Price = 39.99M, Description = "Creative building block set for kids", CategoryId = 5 }
        };
    }
}
