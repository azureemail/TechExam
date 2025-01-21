using Microsoft.EntityFrameworkCore;
using TechExam.Interfaces;
using TechExam.Models;
using TechExam.Data;

namespace TechExam.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Version 1.0 Methods
        public Task<PaginatedProductsDto> GetProductsAnonymous(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = StaticData.Products
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        CategoryName = StaticData.Categories
                                        .FirstOrDefault(c => c.Id == p.CategoryId)?.CategoryName
                    })
                    .ToList();

                var result = new PaginatedProductsDto
                {
                    Message = "Success",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };

                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public Task<PaginatedProductsDto> GetProductsAuthorized(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = StaticData.Products
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        CategoryName = StaticData.Categories
                                        .FirstOrDefault(c => c.Id == p.CategoryId)?.CategoryName
                    })
                    .ToList();

                var result = new PaginatedProductsDto
                {
                    Message = "Success",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };

                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task<PaginatedProductsDto> GetProductLocalDB(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = await _dbContext.Product
                    .Include(p => p.Category)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        CategoryName = p.Category.CategoryName
                    })
                    .ToListAsync();

                return new PaginatedProductsDto
                {
                    Message = "Success",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        // Version 2.0 Methods
        public Task<PaginatedProductsDto> GetProductsAnonymousV2(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = StaticData.Products
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name + " (v2)", 
                        Price = p.Price,
                        Description = p.Description + " - Updated in V2",
                        CategoryName = StaticData.Categories
                                        .FirstOrDefault(c => c.Id == p.CategoryId)?.CategoryName
                    })
                    .ToList();

                var result = new PaginatedProductsDto
                {
                    Message = "Success (v2.0)",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };

                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public Task<PaginatedProductsDto> GetProductsAuthorizedV2(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = StaticData.Products
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name + " (v2)",
                        Price = p.Price,
                        Description = p.Description + " - New in V2",
                        CategoryName = StaticData.Categories
                                        .FirstOrDefault(c => c.Id == p.CategoryId)?.CategoryName
                    })
                    .ToList();

                var result = new PaginatedProductsDto
                {
                    Message = "Success (v2.0)",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };

                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task<PaginatedProductsDto> GetProductLocalDBV2(PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var pageNumber = pageSizeAndNumber.PageNumber;
                var pageSize = pageSizeAndNumber.PageSize;

                var products = await _dbContext.Product
                    .Include(p => p.Category)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(p => new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name + " (v2)",
                        Price = p.Price,
                        Description = p.Description + " - Updated for V2",
                        CategoryName = p.Category.CategoryName
                    })
                    .ToListAsync();

                return new PaginatedProductsDto
                {
                    Message = "Success (v2.0)",
                    Data = products,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalProducts = products.Count
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}

