using ecommerceAPI.Extensions;
using ecommerceAPI.Repositories.Contracts;
using EcommerceModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepositroy productRepositroy;

        public ProductController(IProductRepositroy productRepositroy)
        {
            this.productRepositroy = productRepositroy;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                
                var products = await this.productRepositroy.GetItems();
                var productCategories = await this.productRepositroy.GetCategories();

                if (products == null || productCategories == null)
                    return NotFound();
                else
                {
                    var productDtos = products.ConvertToDto(productCategories);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error receiving data from the database");
            }
        } 
    }
}
