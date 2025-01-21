using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechExam.Interfaces;
using TechExam.Models;

namespace TechExam.Controllers
{
    [Route("api/v{version:apiVersion}/products")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        // API version 1.0
        [ApiVersion("1.0")]
        [HttpPost("getProductAnonymous")]
        [AllowAnonymous]
        public async Task<IActionResult> getProductAnonymous_v1([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductsAnonymous(pageSizeAndNumber);

                return Ok(new
                {
                    Message = result.Message,
                    Products = result.Data,
                    PageNumber = result.PageNumber,
                    PageSize = result.PageSize,
                    TotalProducts = result.TotalProducts
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ApiVersion("1.0")]
        [HttpPost("getProductAuthorized")]
        [Authorize]
        public async Task<IActionResult> getProductAuthorized_v1([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductsAuthorized(pageSizeAndNumber);

                return Ok(new
                {
                    Message = result.Message,
                    Products = result.Data,
                    PageNumber = result.PageNumber,
                    PageSize = result.PageSize,
                    TotalProducts = result.TotalProducts
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ApiVersion("1.0")]
        [HttpPost("getProductLocalDB")]
        [AllowAnonymous]
        public async Task<IActionResult> getProductLocalDB_v1([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductLocalDB(pageSizeAndNumber);

                return Ok(new
                {
                    Message = result.Message,
                    Products = result.Data,
                    PageNumber = result.PageNumber,
                    PageSize = result.PageSize,
                    TotalProducts = result.TotalProducts
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // API version 2.0
        [ApiVersion("2.0")]
        [HttpPost("getProductAnonymous")]
        [AllowAnonymous]
        public async Task<IActionResult> getProductAnonymous_v2([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductsAnonymousV2(pageSizeAndNumber);

                return Ok(new
                {
                    Status = result.Message,
                    Data = result.Data,
                    Paging = new
                    {
                        CurrentPage = result.PageNumber,
                        ItemsPerPage = result.PageSize,
                        TotalItems = result.TotalProducts
                    }
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ApiVersion("2.0")]
        [HttpPost("getProductAuthorized")]
        [Authorize]
        public async Task<IActionResult> getProductAuthorized_v2([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductsAuthorizedV2(pageSizeAndNumber);

                return Ok(new
                {
                    Status = result.Message,
                    Data = result.Data,
                    Paging = new
                    {
                        CurrentPage = result.PageNumber,
                        ItemsPerPage = result.PageSize,
                        TotalItems = result.TotalProducts
                    }
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ApiVersion("2.0")]
        [HttpPost("getProductLocalDB")]
        [AllowAnonymous]
        public async Task<IActionResult> getProductLocalDB_v2([FromBody] PageSizeAndNumber pageSizeAndNumber)
        {
            try
            {
                var result = await _product.GetProductLocalDBV2(pageSizeAndNumber);

                return Ok(new
                {
                    Status = result.Message,
                    Data = result.Data,
                    Paging = new
                    {
                        CurrentPage = result.PageNumber,
                        ItemsPerPage = result.PageSize,
                        TotalItems = result.TotalProducts
                    }
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

