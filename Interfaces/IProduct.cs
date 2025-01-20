using TechExam.Models;

namespace TechExam.Interfaces
{
    public interface IProduct
    {
        Task<PaginatedProductsDto> GetProductsAnonymous(PageSizeAndNumber pageSizeAndNumber);
        Task<PaginatedProductsDto> GetProductsAuthorized(PageSizeAndNumber pageSizeAndNumber);
        Task<PaginatedProductsDto> GetProductLocalDB(PageSizeAndNumber pageSizeAndNumber);
        Task<PaginatedProductsDto> GetProductsAnonymousV2(PageSizeAndNumber pageSizeAndNumber);
        Task<PaginatedProductsDto> GetProductsAuthorizedV2(PageSizeAndNumber pageSizeAndNumber);
        Task<PaginatedProductsDto> GetProductLocalDBV2(PageSizeAndNumber pageSizeAndNumber);
    }
}
